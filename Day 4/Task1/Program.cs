using System;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            double x = 10;
            double resultA = CalculateExpressionA(x);
            if (!double.IsNaN(resultA))
            {
                Console.WriteLine($"Значение выражения a: y = sin({x}) / ({x} - 5) + {x}^3 = {resultA:F4}");
            }

            Console.ReadLine();
        }

        static double CalculateExpressionA(double x)
        {
            try
            {
                double y = Math.Sin(x) / (x - 5) + Math.Pow(x, 3);
                return y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
                return double.NaN;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Неверный формат входных данных.");
                return double.NaN;
            }
        }
    }
}
