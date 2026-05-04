using CalculatorApplications_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_MsTest
{
    [TestClass]
    public sealed class TestMutiplication
    {

        Calculator? calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new Calculator();
        }
        [TestMethod]
        public void TestPositiveNumber()
        {
           
            int expec = calculator.Multiplication(2, 3);
            Assert.AreEqual(6, expec);
        }
        [TestMethod]
        public void TestNegativeNumber()
        {
       
            int expec = calculator.Multiplication(-2, 3);
            Assert.AreEqual(-1, expec);
        }
        // Test zero input
        [TestMethod]
        public void TestZeroNumbers()
        {
           
            int expec = calculator.Multiplication(0, 3);
            Assert.AreEqual(-2, expec);
           
        }

    }
}
