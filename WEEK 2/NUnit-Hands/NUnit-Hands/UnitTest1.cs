using NUnit.Framework;
using CalcLibrary;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void SetUp()
        {
            _calc = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            _calc = null;
        }

        [Test]
        public void Add_WhenCalled_ReturnsSum()
        {
            int result = _calc.Add(5, 3);
            Assert.AreEqual(8, result);
        }

        [TestCase(1, 2, 3)]
        [TestCase(-1, -1, -2)]
        [TestCase(0, 0, 0)]
        public void Add_WithVariousInputs_ReturnsExpected(int a, int b, int expected)
        {
            int result = _calc.Add(a, b);
            Assert.AreEqual(expected, result);
        }

        [Test, Ignore("To be implemented")]
        public void Subtract_Test()
        {
        }
    }
}
