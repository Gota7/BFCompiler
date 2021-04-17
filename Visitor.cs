using System;
using System.Diagnostics.CodeAnalysis;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using LLVMSharp;

// Test scripts can be found here:
// https://github.com/rdebath/Brainfuck/tree/master/testing

/// <summary>
/// For storing information about visiting a node.
/// </summary>
public class VisitResult {
    // Guess we really don't need anything in here.
}

/// <summary>
/// Will visit segments of our code.
/// </summary>
public class Visitor : IBFVisitor<VisitResult> {
    
    // LLVM Module which contains everything.
    public static LLVMModuleRef mod;

    // Builder reference, which will build our instructions.
    static LLVMBuilderRef builder;

    // Pointer that points to our memory pointer.
    static LLVMValueRef ptr;
    
    // Points to the base of our memory such that we make sure to clean it up.
    static LLVMValueRef basePtr;

    // Main method.
    static LLVMValueRef main;

    // For generating variable names (for LLVM's sake). We should never run out of names for a single program.
    static ulong nameGen;

    // How much memory to allocate to our BF program. By default, we'll give it 2 Kb.
    public static ulong memSize = 0x2000;

    // This is used to visit our instructions.
    public static Visitor visitor;

    // Will keep track of our position in memory so that we wrap around instead of go out of bounds.
    static ulong memPos;

    // Function we used to receive user input.
    static LLVMValueRef inputFunc;

    // Function we use to print output.
    static LLVMValueRef outputFunc;

    // Number of loops.
    static ulong loopCount;

    // Return the value pointed to by a pointer.
    LLVMValueRef GetValue(LLVMValueRef ptrToData) {
        return LLVM.BuildLoad(builder, ptrToData, "Load_" + nameGen++);
    }

    // Set the value at a pointer.
    void SetValue(LLVMValueRef ptrToData, LLVMValueRef data) {
        LLVM.BuildStore(builder, data, ptrToData);
    }

    // Return a value that represents the result of either adding or subtracting a value from our input value.
    LLVMValueRef AddSub(LLVMValueRef valueToAddSub, bool sub, ulong value) {
        if (!sub) {
            return LLVM.BuildAdd(builder, valueToAddSub, LLVM.ConstInt(LLVM.Int8Type(), value, false), "Add_" + nameGen++);
        } else {
            return LLVM.BuildSub(builder, valueToAddSub, LLVM.ConstInt(LLVM.Int8Type(), value, false), "Sub_" + nameGen++);
        }
    }

    // Return a value that represents the result of either adding or subtracting a value from our input value, but use 32 bits instead since LLVM is picky with types.
    LLVMValueRef AddSub32(LLVMValueRef valueToAddSub, bool sub, ulong value) {
        if (!sub) {
            return LLVM.BuildAdd(builder, valueToAddSub, LLVM.ConstInt(LLVM.Int32Type(), value, false), "Add_" + nameGen++);
        } else {
            return LLVM.BuildSub(builder, valueToAddSub, LLVM.ConstInt(LLVM.Int32Type(), value, false), "Sub_" + nameGen++);
        }
    }

    // Convert a pointer to an int.
    LLVMValueRef PtrToInt(LLVMValueRef ptr) {
        return LLVM.BuildPtrToInt(builder, ptr, LLVM.Int32Type(), "Ptr2Int_" + nameGen++);
    }

    // Convert an int to a pointer.
    LLVMValueRef IntToPtr(LLVMValueRef val) {
        return LLVM.BuildIntToPtr(builder, val, LLVM.PointerType(LLVM.Int8Type(), 0), "Int2Ptr_" + nameGen++);
    }

    // Achievement get: how did we get here? This function has no references but is needed.
    public VisitResult Visit(IParseTree tree)
    {
        return null;
    }

    // Visit children, no need to define this.
    public VisitResult VisitChildren(IRuleNode node)
    {
        return null;
    }

    // Instruction to decrement the value the memory pointer points to
    public VisitResult VisitDecrement([Antlr4.Runtime.Misc.NotNull] BFParser.DecrementContext context)
    {
        var datPtr = GetValue(ptr);             // Get our actual pointer.
        var dat = GetValue(datPtr);             // Get the data pointed to by the memory pointer.
        SetValue(datPtr, AddSub(dat, true, 1)); // Set the data to be itself minus 1.
        return null;
    }

    // Visit the instruction that defines an entire loop.
    public VisitResult VisitDo_Loop([Antlr4.Runtime.Misc.NotNull] BFParser.Do_LoopContext context)
    {
        for (int i = 0; i < context.ChildCount; i++) {
            context.GetChild(i).Accept(visitor); // Loop is in here.
        }
        return null;
    }

    // Visit an error, this shouldn't happen.
    public VisitResult VisitErrorNode(IErrorNode node)
    {
        return null;
    }

    // Instruction to increment the value our memory pointer points to.
    public VisitResult VisitIncrement([Antlr4.Runtime.Misc.NotNull] BFParser.IncrementContext context)
    {
        var datPtr = GetValue(ptr);                 // Get our actual pointer.
        var dat = GetValue(datPtr);                 // Get the data pointed to by the memory pointer.
        SetValue(datPtr, AddSub(dat, false, 1));    // Set the data to be itself plus 1.
        return null;
    }

    // Init is the rule that defines our entire program.
    public VisitResult VisitInit([Antlr4.Runtime.Misc.NotNull] BFParser.InitContext context)
    {

        // Create our builder.
        builder = LLVM.CreateBuilder();

        // Define all the functions we need to make a BF program. This includes input, output, and memory management programs to get our initial block of memory.
        outputFunc = LLVM.AddFunction(mod, "putchar", LLVM.FunctionType(LLVM.Int32Type(), new LLVMTypeRef[] { LLVM.Int8Type() }, false));
        inputFunc = LLVM.AddFunction(mod, "getchar", LLVM.FunctionType(LLVM.Int8Type(), new LLVMTypeRef[] {}, false));
        var malloc = LLVM.AddFunction(mod, "malloc", LLVM.FunctionType(LLVM.PointerType(LLVM.Int32Type(), 0), new LLVMTypeRef[] { LLVM.Int32Type() }, false));
        var memset = LLVM.AddFunction(mod, "memset", LLVM.FunctionType(LLVM.PointerType(LLVM.Int32Type(), 0), new LLVMTypeRef[] { LLVM.PointerType(LLVM.Int32Type(), 0), LLVM.Int32Type(), LLVM.Int32Type() }, false));
        var free = LLVM.AddFunction(mod, "free", LLVM.FunctionType(LLVM.VoidType(), new LLVMTypeRef[] { LLVM.PointerType(LLVM.Int32Type(), 0) }, false));
        main = LLVM.AddFunction(mod, "main", LLVM.FunctionType(LLVM.VoidType(), new LLVMTypeRef[] {}, false));

        // Start the entry point.
        var entry = LLVM.AppendBasicBlock(main, "entry");
        LLVM.PositionBuilderAtEnd(builder, entry);

        // Call malloc to get a void* (which is actually a int32*) that points to our program memory. We will just allocate a chunk to play with.
        basePtr = LLVM.BuildCall(builder, malloc, new LLVMValueRef[] { LLVM.ConstInt(LLVM.Int32Type(), memSize, false) }, "basePtr");

        // Set memory to 0 (otherwise BF would almost never work).
        LLVM.BuildCall(builder, memset, new LLVMValueRef[] { basePtr, LLVM.ConstInt(LLVM.Int32Type(), 0, true), LLVM.ConstInt(LLVM.Int32Type(), memSize, false) }, "callMemset");

        // Due to how LLVM works, once creating pointer we wouldn't be able to use it again. To counter this, we create a pointer to our pointer.
        ptr = LLVM.BuildAlloca(builder, LLVM.PointerType(LLVM.Int8Type(), 0), "ptr");

        // Cast our void* as a int8* and set our pointer value to it.
        SetValue(ptr, LLVM.BuildPointerCast(builder, basePtr, LLVM.PointerType(LLVM.Int8Type(), 0), "tempPtr"));

        // This is where we actually start adding our program instructions.
        for (int i = 0; i < context.ChildCount; i++) {
            context.GetChild(i).Accept(visitor);
        }

        // Free our malloc'd memory and return nothing.
        LLVM.BuildFree(builder, basePtr);
        LLVM.BuildRetVoid(builder);
        return null;

    }

    // Input instruction. This will scan a character of input, and store it into wherever our memory pointer points to.
    public VisitResult VisitInput([Antlr4.Runtime.Misc.NotNull] BFParser.InputContext context)
    {
        var datPtr = GetValue(ptr); // Get data pointer.
        SetValue(datPtr, LLVM.BuildCall(builder, inputFunc, new LLVMValueRef[] { }, "Input_" + nameGen++)); // Read a char and store it where the pointer points to.
        return null;
    }

    // Visit the loop.
    public VisitResult VisitLoop([Antlr4.Runtime.Misc.NotNull] BFParser.LoopContext context)
    {
        
        // Add loop blocks.
        var start = LLVM.AppendBasicBlock(main, "loop_" + loopCount + "_start");
        var end = LLVM.AppendBasicBlock(main, "loop_" + loopCount + "_end");

        // Skip everything if value is 0.
        LLVM.BuildCondBr(builder, LLVM.BuildICmp(builder, LLVMIntPredicate.LLVMIntNE, GetValue(GetValue(ptr)), LLVM.ConstInt(LLVM.Int8Type(), 0, false), "loop_" + loopCount++ + "_compare"), start, end);

        // Instructions inside.
        LLVM.PositionBuilderAtEnd(builder, start);
        for (int i = 1; i < context.ChildCount - 1; i++) {
            context.children[i].Accept(visitor);
        }

        // Jump back if value at pointer is nonzero.
        LLVM.BuildCondBr(builder, LLVM.BuildICmp(builder, LLVMIntPredicate.LLVMIntNE, GetValue(GetValue(ptr)), LLVM.ConstInt(LLVM.Int8Type(), 0, false), "loop_" + (loopCount - 1) + "_compare2"), start, end);
        LLVM.PositionBuilderAtEnd(builder, end);

        // Return nothing.
        return null;

    }

    // Move our pointer to the left.
    public VisitResult VisitMove_Left([Antlr4.Runtime.Misc.NotNull] BFParser.Move_LeftContext context)
    {
        if (memPos == 0) { // Wrap around to the furthest right.
            memPos += memSize - 1;
            var datPtr = GetValue(ptr); // Get data pointer.
            SetValue(ptr, IntToPtr(AddSub32(PtrToInt(datPtr), false, memSize - 1))); // Do the math operations to our pointer, which involves converting it than reconverting it.
        } else { // Move left.
            memPos--;
            var datPtr = GetValue(ptr); // Get data pointer.
            SetValue(ptr, IntToPtr(AddSub32(PtrToInt(datPtr), true, 1))); // Do the math operations to our pointer, which involves converting it than reconverting it.
        }
        return null;
    }

    // Move our pointer to the right.
    public VisitResult VisitMove_Right([Antlr4.Runtime.Misc.NotNull] BFParser.Move_RightContext context)
    {
        if (memPos == memSize - 1) { // Wrap around to the furthest left.
            memPos = 0;
            var datPtr = GetValue(ptr); // Get data pointer.
            SetValue(ptr, IntToPtr(AddSub32(PtrToInt(datPtr), true, memSize - 1))); // Do the math operations to our pointer, which involves converting it than reconverting it.
        } else { // Move right.
            memPos++;
            var datPtr = GetValue(ptr); // Get data pointer.
            SetValue(ptr, IntToPtr(AddSub32(PtrToInt(datPtr), false, 1))); // Do the math operations to our pointer, which involves converting it than reconverting it.
        }
        return null;
    }

    // Output the data our pointer points to.
    public VisitResult VisitOutput([Antlr4.Runtime.Misc.NotNull] BFParser.OutputContext context)
    {
        LLVM.BuildCall(builder, outputFunc, new LLVMValueRef[] { GetValue(GetValue(ptr)) }, "Output_" + nameGen++); // Simply just output the value pointed to by the data pointer.
        return null;
    }

    // What does this even mean? Don't care.
    public VisitResult VisitTerminal(ITerminalNode node)
    {
        return null;
    }

}