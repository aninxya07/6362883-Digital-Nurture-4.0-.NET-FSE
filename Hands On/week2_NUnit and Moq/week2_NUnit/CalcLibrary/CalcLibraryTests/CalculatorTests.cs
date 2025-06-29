using NUnit.Framework;
using CalcLibrary;

namespace CalcLibraryTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void Teardown()
        {
            calculator = null;
        }

        [TestCase(5.0, 3.0, 8.0)]
        [TestCase(-2.5, 2.5, 0.0)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(1.111, 2.222, 3.333)]
        public void Addition_ShouldReturnExpectedResult(double a, double b, double expected)
        {
            double result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected).Within(0.0001));
        }
    }
}
