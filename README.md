# BF Compiler
A compiler for the [BF](https://esolangs.org/wiki/Brainfuck) language.

## About
This is a BF compiler written using ANTLR4 and LLVM. This is built in the same way as the Toy language in my tutorial series, https://gota7.github.io/GotaGuide/ProgrammingLanguage/Index.html, and this will probably become a part of it. The most interesting code files are Antlr/BF.g4 and Visitor.cs.
## Requirements
Building requires .NET 5.0 along with having the clang compiler installed to use the bitcode practically.

## Usage
The compiler utilizes LLVM to emit LLVM bitcode, which is then to be compiled with clang.
```Usage: BFCompiler [Input] [Flags]
	-m Set program memory size (8192 bytes by default).
	-o Set output filename.
	c2021 Gota7
```
After running the compiler to produce a `.bc` file, you use clang as such:
`clang HelloWorld.bc -o HelloWorld.elf`

## Standard In
Executables will read input from standard in, meaning programs input can be piped as such:
`cat Input.txt | ./MyProgram.elf`
