using System;
using System.Collections.Generic;
using System.Text;
using CalculatorApplications_Testing;

namespace Calculator_Xunit
{
    public class TestAddition
    {
        Calculator calculator;        
        public TestAddition()
        {
            calculator = new Calculator();  
        }

        [Fact]
        public void TestPotivitDivison()
        {
            int res = calculator.Division(4, 2);
            Assert.Equal(2, res);
            
        }

        [Fact]
        public void TestPotivitDivison2()
        {
            int res =calculator.Division(4, -2);
            Assert.Equal(-2, res);
        }
    }
}
