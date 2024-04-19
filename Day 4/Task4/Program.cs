using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a1 = 5.0;
            double a2 = 7.0;
            double a3 = 10.0;

            double P1, S1, P2, S2, P3, S3;
            try
            {
                TrianglePS(a1, out P1, out S1);
                TrianglePS(a2, out P2, out S2);
                TrianglePS(a3, out P3, out S3);

                Console.WriteLine($"Треугольник со стороной {a1}: Периметр = {P1}, Площадь = {S1}");
                Console.WriteLine($"Треугольник со стороной {a2}: Периметр = {P2}, Площадь = {S2}");
                Console.WriteLine($"Треугольник со стороной {a3}: Периметр = {P3}, Площадь = {S3}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Ошибка деления на ноль: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Ошибка формата: {ex.Message}");
            }

            Console.ReadLine();
        }

        static void TrianglePS(double a, out double P, out double S)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Сторона треугольника должна быть положительным числом.");
            }

            P = 3 * a;
            S = (a * a * Math.Sqrt(3)) / 4;
        }
    }
}
