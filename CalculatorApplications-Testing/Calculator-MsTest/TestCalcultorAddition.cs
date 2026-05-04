using System;
using System.Collections.Generic;
using System.Text;
using CalculatorApplications_Testing;

namespace Calculator_MsTest
{
    [TestClass]
    public sealed class TestCalcultorAddition
    {
        [TestMethod]
        public void TestPotiviteInput()
        {
            Calculator calculator = new Calculator();
            var expected = calculator.Addition(2, 3);
            Assert.AreEqual(5, expected);
        }

        [TestMethod]
        public void TestNegativeInput()
        {
            Calculator calculator = new Calculator();
            var expected = calculator.Addition(-2, 3);

            int actual = -1;
            Assert.AreEqual(expected, actual);
            
        }

    }
}
