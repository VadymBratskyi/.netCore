using MyCalcLibrery;
using NSubstitute;
using NUnit.Framework;

namespace NUnitTestSubstitute
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			var calc = Substitute.For<ICalculate>();
			calc.Sum(1, 2).Returns(3);

			Assert.That(calc.Sum(1, 2), Is.EqualTo(3));
		}
	}
}