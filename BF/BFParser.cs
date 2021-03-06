//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from BF.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class BFParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		MV_RIGHT=1, MV_LEFT=2, INC=3, DEC=4, OUTPUT=5, INPUT=6, LOOP_CHECK=7, 
		LOOP_BOUNCE=8, OTHER=9;
	public const int
		RULE_init = 0, RULE_instruction = 1, RULE_loop = 2;
	public static readonly string[] ruleNames = {
		"init", "instruction", "loop"
	};

	private static readonly string[] _LiteralNames = {
		null, "'>'", "'<'", "'+'", "'-'", "'.'", "','", "'['", "']'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "MV_RIGHT", "MV_LEFT", "INC", "DEC", "OUTPUT", "INPUT", "LOOP_CHECK", 
		"LOOP_BOUNCE", "OTHER"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "BF.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static BFParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public BFParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public BFParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class InitContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext[] instruction() {
			return GetRuleContexts<InstructionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext instruction(int i) {
			return GetRuleContext<InstructionContext>(i);
		}
		public InitContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_init; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterInit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitInit(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInit(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InitContext init() {
		InitContext _localctx = new InitContext(Context, State);
		EnterRule(_localctx, 0, RULE_init);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 9;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MV_RIGHT) | (1L << MV_LEFT) | (1L << INC) | (1L << DEC) | (1L << OUTPUT) | (1L << INPUT) | (1L << LOOP_CHECK))) != 0)) {
				{
				{
				State = 6;
				instruction();
				}
				}
				State = 11;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InstructionContext : ParserRuleContext {
		public InstructionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_instruction; } }
	 
		public InstructionContext() { }
		public virtual void CopyFrom(InstructionContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class InputContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INPUT() { return GetToken(BFParser.INPUT, 0); }
		public InputContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterInput(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitInput(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInput(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class DecrementContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode DEC() { return GetToken(BFParser.DEC, 0); }
		public DecrementContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterDecrement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitDecrement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDecrement(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class IncrementContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INC() { return GetToken(BFParser.INC, 0); }
		public IncrementContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterIncrement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitIncrement(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitIncrement(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class OutputContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OUTPUT() { return GetToken(BFParser.OUTPUT, 0); }
		public OutputContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterOutput(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitOutput(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitOutput(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Do_LoopContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public LoopContext loop() {
			return GetRuleContext<LoopContext>(0);
		}
		public Do_LoopContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterDo_Loop(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitDo_Loop(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDo_Loop(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Move_RightContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MV_RIGHT() { return GetToken(BFParser.MV_RIGHT, 0); }
		public Move_RightContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterMove_Right(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitMove_Right(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMove_Right(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class Move_LeftContext : InstructionContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MV_LEFT() { return GetToken(BFParser.MV_LEFT, 0); }
		public Move_LeftContext(InstructionContext context) { CopyFrom(context); }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterMove_Left(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitMove_Left(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMove_Left(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InstructionContext instruction() {
		InstructionContext _localctx = new InstructionContext(Context, State);
		EnterRule(_localctx, 2, RULE_instruction);
		try {
			State = 19;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LOOP_CHECK:
				_localctx = new Do_LoopContext(_localctx);
				EnterOuterAlt(_localctx, 1);
				{
				State = 12;
				loop();
				}
				break;
			case MV_RIGHT:
				_localctx = new Move_RightContext(_localctx);
				EnterOuterAlt(_localctx, 2);
				{
				State = 13;
				Match(MV_RIGHT);
				}
				break;
			case MV_LEFT:
				_localctx = new Move_LeftContext(_localctx);
				EnterOuterAlt(_localctx, 3);
				{
				State = 14;
				Match(MV_LEFT);
				}
				break;
			case INC:
				_localctx = new IncrementContext(_localctx);
				EnterOuterAlt(_localctx, 4);
				{
				State = 15;
				Match(INC);
				}
				break;
			case DEC:
				_localctx = new DecrementContext(_localctx);
				EnterOuterAlt(_localctx, 5);
				{
				State = 16;
				Match(DEC);
				}
				break;
			case OUTPUT:
				_localctx = new OutputContext(_localctx);
				EnterOuterAlt(_localctx, 6);
				{
				State = 17;
				Match(OUTPUT);
				}
				break;
			case INPUT:
				_localctx = new InputContext(_localctx);
				EnterOuterAlt(_localctx, 7);
				{
				State = 18;
				Match(INPUT);
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LoopContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LOOP_CHECK() { return GetToken(BFParser.LOOP_CHECK, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode LOOP_BOUNCE() { return GetToken(BFParser.LOOP_BOUNCE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext[] instruction() {
			return GetRuleContexts<InstructionContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public InstructionContext instruction(int i) {
			return GetRuleContext<InstructionContext>(i);
		}
		public LoopContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_loop; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.EnterLoop(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			IBFListener typedListener = listener as IBFListener;
			if (typedListener != null) typedListener.ExitLoop(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IBFVisitor<TResult> typedVisitor = visitor as IBFVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLoop(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LoopContext loop() {
		LoopContext _localctx = new LoopContext(Context, State);
		EnterRule(_localctx, 4, RULE_loop);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			Match(LOOP_CHECK);
			State = 25;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << MV_RIGHT) | (1L << MV_LEFT) | (1L << INC) | (1L << DEC) | (1L << OUTPUT) | (1L << INPUT) | (1L << LOOP_CHECK))) != 0)) {
				{
				{
				State = 22;
				instruction();
				}
				}
				State = 27;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 28;
			Match(LOOP_BOUNCE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\v', '!', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', '\t', 
		'\x3', '\x4', '\x4', '\t', '\x4', '\x3', '\x2', '\a', '\x2', '\n', '\n', 
		'\x2', '\f', '\x2', '\xE', '\x2', '\r', '\v', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x5', '\x3', '\x16', '\n', '\x3', '\x3', '\x4', '\x3', '\x4', 
		'\a', '\x4', '\x1A', '\n', '\x4', '\f', '\x4', '\xE', '\x4', '\x1D', '\v', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x2', '\x2', '\x5', 
		'\x2', '\x4', '\x6', '\x2', '\x2', '\x2', '%', '\x2', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\x4', '\x15', '\x3', '\x2', '\x2', '\x2', '\x6', '\x17', 
		'\x3', '\x2', '\x2', '\x2', '\b', '\n', '\x5', '\x4', '\x3', '\x2', '\t', 
		'\b', '\x3', '\x2', '\x2', '\x2', '\n', '\r', '\x3', '\x2', '\x2', '\x2', 
		'\v', '\t', '\x3', '\x2', '\x2', '\x2', '\v', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\f', '\x3', '\x3', '\x2', '\x2', '\x2', '\r', '\v', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\x16', '\x5', '\x6', '\x4', '\x2', '\xF', '\x16', 
		'\a', '\x3', '\x2', '\x2', '\x10', '\x16', '\a', '\x4', '\x2', '\x2', 
		'\x11', '\x16', '\a', '\x5', '\x2', '\x2', '\x12', '\x16', '\a', '\x6', 
		'\x2', '\x2', '\x13', '\x16', '\a', '\a', '\x2', '\x2', '\x14', '\x16', 
		'\a', '\b', '\x2', '\x2', '\x15', '\xE', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x15', '\x10', '\x3', '\x2', '\x2', 
		'\x2', '\x15', '\x11', '\x3', '\x2', '\x2', '\x2', '\x15', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '\x15', '\x13', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\x16', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\x1B', '\a', '\t', '\x2', '\x2', '\x18', '\x1A', '\x5', 
		'\x4', '\x3', '\x2', '\x19', '\x18', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x1B', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1C', '\x1E', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\a', '\n', '\x2', '\x2', '\x1F', '\a', '\x3', '\x2', '\x2', '\x2', 
		'\x5', '\v', '\x15', '\x1B',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
