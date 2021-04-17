using System;
using System.IO;
using Antlr4.Runtime;
using LLVMSharp;

namespace BFCompiler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1) {
                Console.WriteLine("Usage: BFCompiler [Input] [Flags]");
                Console.WriteLine("\t-m Set memory size (8192 bytes by default).");
                Console.WriteLine("\t-o Set output filename.");
                Console.WriteLine("\tc2021 Gota7");
            } else {
                string inName = "";
                string outName = "";
                ulong memSize = 0x2000;
                try {
                    for (int i = 0; i < args.Length; i++) {
                        switch (args[i]) {
                            case "-m":
                                memSize = ulong.Parse(args[i + 1]);
                                i++;
                                break;
                            case "-o":
                                outName = args[i + 1];
                                i++;
                                break;
                            default:
                                inName = args[i];
                                if (outName.Equals("")) {
                                    outName = Path.GetFileNameWithoutExtension(inName) + ".bc";
                                }
                                break;
                        }
                    }
                } catch { 
                    Console.WriteLine("Usage: BFCompiler [Input] [Flags]");
                    Console.WriteLine("\t-m Set memory size (8192 bytes by default).");
                    Console.WriteLine("\t-o Set output filename.");
                    Console.WriteLine("\tc2021 Gota7");
                    Environment.Exit(0);
                }
                if (inName.Equals("") || outName.Equals("")) {
                    Console.WriteLine("Usage: BFCompiler [Input] [Flags]");
                    Console.WriteLine("\t-m Set program memory size (8192 bytes by default).");
                    Console.WriteLine("\t-o Set output filename.");
                    Console.WriteLine("\tc2021 Gota7");
                    Environment.Exit(0);
                }
                using (StreamReader fileStream = new StreamReader(inName)) {
                    AntlrInputStream input = new AntlrInputStream(fileStream);
                    BFLexer lexer = new BFLexer(input);
                    CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                    BFParser parser = new BFParser(commonTokenStream);
                    Visitor visitor = new Visitor();
                    Visitor.visitor = visitor;
                    Visitor.memSize = memSize;
                    Visitor.mod = LLVM.ModuleCreateWithName(Path.GetFileNameWithoutExtension(outName));
                    visitor.VisitInit(parser.init());
                    LLVM.WriteBitcodeToFile(Visitor.mod, outName);
                }
            }
        }
    }
}
