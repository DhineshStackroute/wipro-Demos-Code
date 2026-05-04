using CalculatorApplications_Testing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Xunit
{
    public class TestAllCalcultorFunction
    {
        Calculator calculator;
        public TestAllCalcultorFunction()
        {
            calculator = new Calculator();
        }

        // Test method to all input and output for addition
        // one test method for one functions
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(-1, 4, -1)]
        [InlineData(245, 234, 479)]

        public void TestAllAddition(int inp1, int inp2, int expected)
        {
            int actual = calculator.Addition(inp1, inp2);
            Assert.Equal(expected,actual);
         
        }
    }
}
