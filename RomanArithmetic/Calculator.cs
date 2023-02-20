using Sprache;
using System.Text;

namespace RomanArithmetic;

public class Calculator
{
	public string Evaluate(string input)
	{
		var number = Grammar.Expression.Parse(input);
		return ConvertToRoman(number.Value);
	}

	private string ConvertToRoman(int value)
	{
		var result = new StringBuilder();

		if (value < 0) {
			result.Append('-');
			value = Math.Abs(value);
		}

		while (value > 0)
		{
			if (value >= 1000)
			{
				result.Append('M');
				value -= 1000;
			}
			else if (value >= 900)
			{
				result.Append("CM");
				value -= 900;
			}
			else if (value >= 500)
			{
				result.Append('D');
				value -= 500;
			}
			else if (value >= 400)
			{
				result.Append("CD");
				value -= 400;
			}
			else if (value >= 100)
			{
				result.Append('C');
				value -= 100;
			}
			else if (value >= 90)
			{
				result.Append("XC");
				value -= 90;
			}
			else if (value >= 50)
			{
				result.Append('L');
				value -= 50;
			}
			else if (value >= 40)
			{
				result.Append("XL");
				value -= 40;
			}
			else if (value >= 10)
			{
				result.Append('X');
				value -= 10;
			}
			else if (value >= 9)
			{
				result.Append("IX");
				value -= 9;
			}
			else if (value >= 5)
			{
				result.Append('V');
				value -= 5;
			}
			else if (value >= 4)
			{
				result.Append("IV");
				value -= 4;
			}
			else if (value >= 1)
			{
				result.Append('I');
				value -= 1;
			}
		}
		return result.ToString();
	}
}