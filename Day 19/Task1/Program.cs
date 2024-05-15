using System;

namespace Task1
{
    /// <summary>
    /// A program to tabulate the function f(x) = x^2 + 2x.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the initial value of 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter the final value of 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter the step size 'h': ");
            double h = double.Parse(Console.ReadLine());

            TabulateFunction(a, b, h);

            Console.ReadLine();
        }

        /// <summary>
        /// Tabulates the function f(x) = x^2 + 2x for the given range.
        /// </summary>
        /// <param name="a">Initial value of 'x'.</param>
        /// <param name="b">Final value of 'x'.</param>
        /// <param name="h">Step size.</param>
        static void TabulateFunction(double a, double b, double h)
        {
            Console.WriteLine("x\tf(x)");

            for (double x = a; x <= b; x += h)
            {
                double fx = x * x + 2 * x;
                Console.WriteLine($"{x}\t{fx}");
            }
        }
    }
}
