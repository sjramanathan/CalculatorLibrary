using System;

namespace Calculator
{
    public class SimpleCalculator
    {
        public SimpleCalculator() { }

        public double Calculate (double a, double b, String ops)
        {
            switch (ops)
            {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    if (b == 0)
                    {
                        throw new ArithmeticException();
                    }
                    return a / b;
                default:
                    throw new ArithmeticException();
            }
        }
    }
}
