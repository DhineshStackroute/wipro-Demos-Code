using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplications_Testing
{
    // design a calculator to add teh positve numbers
    public class Calculator
    {
        // Define a methods for addition , subtraction , mutiplation and division

        public int Addition(int x, int y)
        {
            if (x <= 0 || y <= 0)
            {
                return -1;
            }
            else
            {
                return x + y;
            }
        }

        public int Subtraction(int x, int y)
        { return x - y; }
        public int Multiplication(int x, int y)
        {

            if (x < 0 || y < 0)
            {
                return -1;
            }
            else if(x==0 || y==0)
            {
                return -2;
            }
            else
            {
                return x * y;
            }
        }
        public int Division(int x, int y)
        { return x / y; }

    }
}
