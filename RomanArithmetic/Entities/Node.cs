using RomanArithmetic.Enums;

namespace RomanArithmetic.Entities;

internal class Node
{
	public int Value { get; }

	public Node(int value)
	{
		Value = value;
	}

	public Node(int a, int b, Operator operation)
	{
		switch (operation)
		{
			case Operator.Add:
				Value = a + b;
				break;
			case Operator.Subtract:
				Value = a - b;
				break;
			case Operator.Multiply:
				Value = a * b;
				break;
			case Operator.Divide:
				Value = a / b;
				break;
			case Operator.Power:
				Value = (int)Math.Pow(a, b);
				break;
			default:
				throw new InvalidOperationException($"Operation {operation} is not supported.");
		}
	}
}
