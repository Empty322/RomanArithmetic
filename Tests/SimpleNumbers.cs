namespace Tests;

public class SimpleNumbers
{
	private readonly Calculator calculator = new Calculator();

	[Test]
	public void ShouldParse1()
	{
		var result = calculator.Evaluate("I");
		var expected = "I";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse4()
	{
		var result = calculator.Evaluate("IV");
		var expected = "IV";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse5()
	{
		var result = calculator.Evaluate("V");
		var expected = "V";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse9()
	{
		var result = calculator.Evaluate("IX");
		var expected = "IX";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse10()
	{
		var result = calculator.Evaluate("X");
		var expected = "X";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse40()
	{
		var result = calculator.Evaluate("XL");
		var expected = "XL";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse50()
	{
		var result = calculator.Evaluate("L");
		var expected = "L";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse90()
	{
		var result = calculator.Evaluate("XC");
		var expected = "XC";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse100()
	{
		var result = calculator.Evaluate("C");
		var expected = "C";

	}

	[Test]
	public void ShouldParse400()
	{
		var result = calculator.Evaluate("CD");
		var expected = "CD";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse500()
	{
		var result = calculator.Evaluate("D");
		var expected = "D";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse900()
	{
		var result = calculator.Evaluate("CM");
		var expected = "CM";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse1000()
	{
		var result = calculator.Evaluate("M");
		var expected = "M";

		Assert.That(result, Is.EqualTo(expected));
	}
}