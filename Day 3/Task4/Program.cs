using System;

namespace Task4
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите a1: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.Write("Введите b1: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.Write("Введите a2: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.Write("Введите b2: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.Write("Введите c2: ");
            double c2 = double.Parse(Console.ReadLine());

            double result = Max(a1, b1) - Max(a2, b2, c2);
            Console.WriteLine($"Результат: {result}");

            Console.ReadLine();
        }

        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        public static double Max(double a, double b, double c)
        {
            return Max(Max(a, b), c);
        }
    }
}
