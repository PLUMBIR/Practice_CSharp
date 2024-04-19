using System;

namespace Task2
{
    public class Program
    {
        static void Main()
        {
            double x = 10;
            double resultB = CalculateExpressionB(x);
            if (!double.IsNaN(resultB))
            {
                Console.WriteLine($"Значение выражения b: y = ln({x}) - cos({x}) / (3*{x} + 6) = {resultB:F4}");
            }

            Console.ReadLine();
        }

        static double CalculateExpressionB(double x)
        {
            try
            {
                double y = Math.Log(x) - Math.Cos(x) / (3 * x + 6);
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
