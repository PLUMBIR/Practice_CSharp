using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        const int ARGUMENT_A = 2;
        const int ARGUMENT_B = 12;

        static void Main(string[] args)
        {
            Parallel.For(ARGUMENT_A, ARGUMENT_B + 1, i =>
            {
                double result = Math.Tan(i);
                Console.WriteLine($"Значение функции Sin({i}) - Cos({i}) = {result}");
            });

            Console.ReadLine();
        }
    }

}
