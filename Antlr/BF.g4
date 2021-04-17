grammar BF;

// Entry point.
init
	:	instruction*
	;

// Universal statement.
instruction
	:	loop 				# Do_Loop
	|	MV_RIGHT			# Move_Right
	|	MV_LEFT				# Move_Left
	|	INC					# Increment
	|	DEC					# Decrement
	|	OUTPUT				# Output
	|	INPUT				# Input
	;

// Loop.
loop
	:	LOOP_CHECK instruction* LOOP_BOUNCE
	;

// Instructions.
MV_RIGHT:		'>';	
MV_LEFT:		'<';
INC:			'+';
DEC:			'-';
OUTPUT:			'.';
INPUT:			',';
LOOP_CHECK:		'[';
LOOP_BOUNCE:	']';

// Comment.
OTHER: .+? -> skip;
