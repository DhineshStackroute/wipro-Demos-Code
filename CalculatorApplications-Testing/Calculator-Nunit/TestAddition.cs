using System;
using System.Collections.Generic;
using System.Text;

using CalculatorApplications_Testing;
using NUnit.Framework.Legacy;

namespace Calculator_Nunit
{
    [TestFixture]
    public class TestAddition
    {
        Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [Test]
       public void TestPoitiveAddition()
        {   
        
            int expected = calculator.Addition(2, 3);
            //Assert.Equals(expected, 5);
            //Assert.That.Equals(expected, expected);
            Assert.That(expected, Is.EqualTo(5));
            //Assert.That(expected, Is.TypeOf(typeof(int)));
            //ClassicAssert.AreEqual(expected, expected);
        }
    }
}
