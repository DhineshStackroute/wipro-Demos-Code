using CalculatorApplications_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Nunit
{
    [TestFixture]
    public class TestAllCalcultorFuncr
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }
        [TestCase(1, 2, 2)]
        [TestCase(-1, 2, -1)]
        [TestCase(4, 0, -2)]
        public void TestAllMultiplationTestcase(int inp1, int inp2, int reexpectedsult)
        {
            int actual = calculator.Multiplication(inp1, inp2);
            Assert.That(actual, Is.EqualTo(reexpectedsult));
        }

        [TestCase(1, 2, ExpectedResult = 2)]
        [TestCase(-1, 2, ExpectedResult =-1)]
        [TestCase(4, 0, ExpectedResult =-2)]
        public int TestAllMultiplation(int inp1, int inp2)
        {
            int actual = calculator.Multiplication(inp1, inp2);
            return actual;
        }
    }
}
