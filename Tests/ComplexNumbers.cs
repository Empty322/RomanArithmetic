using Sprache;

namespace Tests;

public class ComplexNumbers
{
	private readonly Calculator calculator = new Calculator();

	[Test]
	public void ShouldParse6()
	{
		var result = calculator.Evaluate("VI");
		var expected = "VI";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldNotParse6()
	{
		Assert.Throws<ParseException>(() => calculator.Evaluate(" V I "));
	}

	[Test]
	public void ShouldParse7()
	{
		var result = calculator.Evaluate("VII");
		var expected = "VII";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse8()
	{
		var result = calculator.Evaluate("VIII");
		var expected = "VIII";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse1556()
	{
		var result = calculator.Evaluate("MDLVI");
		var expected = "MDLVI";

		Assert.That(result, Is.EqualTo(expected));
	}

	[Test]
	public void ShouldParse3098()
	{
		var result = calculator.Evaluate("MMMXCVIII");
		var expected = "MMMXCVIII";

		Assert.That(result, Is.EqualTo(expected));
	}
}