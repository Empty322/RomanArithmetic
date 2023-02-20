namespace Tests;

public class Expressions
{
	private readonly Calculator calculator = new Calculator();

	[Test]
	public void SingleAdd()
	{
		var input = "V + III";
		var expected = "VIII";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DoubleAdd()
	{
		var input = "V + III + XXI";
		var expected = "XXIX";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void SingleSubtract()
	{
		var input = "V - III";
		var expected = "II";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DoubleSubtract()
	{
		var input = "XXI - III - VI";
		var expected = "XII";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void SingleMultiply()
	{
		var input = "V * X";
		var expected = "L";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DoubleMultiply()
	{
		var input = "V * X * III";
		var expected = "CL";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void SingleDivide()
	{
		var input = "X / II";
		var expected = "V";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DoubleDivide()
	{
		var input = "C / III / II";
		var expected = "XVI";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void Pow()
	{
		var input = "V ^ II";
		var expected = "XXV";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DoublePow()
	{
		var input = "V ^ II ^ II";
		var expected = "DCXXV";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void AddSubtract()
	{
		var input = "X + II - V";
		var expected = "VII";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void SubtractAdd()
	{
		var input = "X - II + V";
		var expected = "XIII";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void MultiplyDivide()
	{
		var input = "X * V / II";
		var expected = "XXV";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void DivideMultiply()
	{
		var input = "X / II * III";
		var expected = "XV";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void Complex()
	{
		var input = "I + II * V ^ II ^ II / V - XL";
		var expected = "CCXI";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void Complex2()
	{
		var input = "V ^ II ^ II * II + I";
		var expected = "MCCLI";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void Complex3()
	{
		var input = "(MMMDCCXXIV - MMCCXXIX) * II";
		var expected = "MMCMXC";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}

	[Test]
	public void Complex4()
	{
		var input = "((CCCXXX * V + MMMCCC / XXXIII) - (DXXIII - (DLX / LXXX)^(II + I)) * (XIII^V * II + CLI)) / (DC * DCCCXXXIII)";
		var expected = "-CCLXVII";

		string actual = calculator.Evaluate(input);

		Assert.That(actual, Is.EqualTo(expected));
	}
}