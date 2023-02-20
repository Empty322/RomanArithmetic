using RomanArithmetic.Entities;
using RomanArithmetic.Enums;
using Sprache;

namespace RomanArithmetic;

internal static class Grammar
{
	private static readonly Parser<Node> One = Parse.Char('I').Return(new Node(1));
	private static readonly Parser<Node> Four = Parse.String("IV").Return(new Node(4));
	private static readonly Parser<Node> Five = Parse.Char('V').Return(new Node(5));
	private static readonly Parser<Node> Nine = Parse.String("IX").Return(new Node(9));
	private static readonly Parser<Node> Ten = Parse.Char('X').Return(new Node(10));
	private static readonly Parser<Node> Fourty = Parse.String("XL").Return(new Node(40));
	private static readonly Parser<Node> Fifty = Parse.Char('L').Return(new Node(50));
	private static readonly Parser<Node> Ninty = Parse.String("XC").Return(new Node(90));
	private static readonly Parser<Node> Hundred = Parse.Char('C').Return(new Node(100));
	private static readonly Parser<Node> FourHundreds = Parse.String("CD").Return(new Node(400));
	private static readonly Parser<Node> FiveHundreds = Parse.Char('D').Return(new Node(500));
	private static readonly Parser<Node> NineHundreds = Parse.String("CM").Return(new Node(900));
	private static readonly Parser<Node> Thousand = Parse.Char('M').Return(new Node(1000));

	private static readonly Parser<Node> NumberPart = 
		Four
		.Or(Nine)
		.Or(Fourty)
		.Or(Ninty)
		.Or(FourHundreds)
		.Or(NineHundreds)
		.Or(One)
		.Or(Five)
		.Or(Ten)
		.Or(Fifty)
		.Or(Hundred)
		.Or(FiveHundreds)
		.Or(Thousand);

	private static readonly Parser<Node> Number = 
		from numbers in NumberPart.AtLeastOnce().Token()
		select new Node(numbers.Sum(x => x.Value));

	private static readonly Parser<Operator> AddOperator = Parse.Char('+').Token().Return(Operator.Add);
	private static readonly Parser<Operator> SubtractOperator = Parse.Char('-').Token().Return(Operator.Subtract);
	private static readonly Parser<Operator> MultiplyOperator = Parse.Char('*').Token().Return(Operator.Multiply);
	private static readonly Parser<Operator> DevideOperator = Parse.Char('/').Token().Return(Operator.Divide);
	private static readonly Parser<Operator> PowOperator = Parse.Char('^').Token().Return(Operator.Power);

	private static readonly Parser<Node> SubExpression =
		from open in Parse.Char('(').Token()
		from expression in ThirdPriorityOperation
		from close in Parse.Char(')').Token()
		select expression;

	private static readonly Parser<Node> FirstPriorityOperation = 
		Parse.XChainRightOperator(
			PowOperator, 
			SubExpression.Or(Number), 
			(op, left, right) => new Node(left.Value, right.Value, op));

	private static readonly Parser<Node> SecondPriorityOperation = 
		Parse.XChainOperator(
			MultiplyOperator.Or(DevideOperator), 
			FirstPriorityOperation, 
			(op, left, right) => new Node(left.Value, right.Value, op));

	private static readonly Parser<Node> ThirdPriorityOperation = 
			Parse.XChainOperator(
				AddOperator.Or(SubtractOperator), 
				SecondPriorityOperation, 
				(op, left, right) => new Node(left.Value, right.Value, op));

	public static readonly Parser<Node> Expression = ThirdPriorityOperation.End();
}
