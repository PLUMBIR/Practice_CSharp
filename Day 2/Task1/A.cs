using System;

namespace Task1
{
    class A
    {
        private int a;
        private int b;

        public A(int aValue, int bValue)
        {
            a = aValue;
            b = bValue;
        }

        public double CalculateQuotient()
        {
            if (b != 0)
                return (double)a / b;
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        public double CalculateExpression()
        {
            return Math.Pow(a + b, 1.0 / 3.0);
        }
    }
}
