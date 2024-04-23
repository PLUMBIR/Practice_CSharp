using System;
using System.Linq;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] realNumbers = { 1.5, 2.7, 3.2, 4.8, 5.3 };

            double average = realNumbers.Average();

            Console.WriteLine($"Среднее арифметическое вещественных чисел: {average}");

            Console.ReadLine();
        }
    }
}
