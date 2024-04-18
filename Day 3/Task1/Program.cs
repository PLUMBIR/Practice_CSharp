using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное значение a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите шаг h: ");
            double h = double.Parse(Console.ReadLine());

            TabulateFunction(a, b, h);

            Console.ReadLine();
        }

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
