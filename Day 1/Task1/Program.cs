using System;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите значение x: ");

            double x = double.Parse(Console.ReadLine());

            double y = CalculateFunction(x);

            Console.WriteLine($"Значение функции y при x = {x} равно {y}");

            Console.ReadLine();
        }

        static double CalculateFunction(double x)
        {
            if (x >= 1 && x <= 3)
            {
                return 2 * Math.Pow(x, 2) - 3 * Math.Exp(Math.Sin(x));
            }
            else if (x > 3)
            {
                return 3 * Math.Tan(x);
            }
            else
            {
                throw new ArgumentException("Функция не определена для x < 1.");
            }
        }
    }
}
