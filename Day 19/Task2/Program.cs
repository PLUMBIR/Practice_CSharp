using System;

namespace Task2
{
    /// <summary>
    /// Программа для вычисления периметра и площади прямоугольника.
    /// </summary>
    class Program
    {
        static void Main()
        {
            double x1 = 1.0;
            double y1 = 2.0;
            double x2 = 5.0;
            double y2 = 6.0;

            double P, S;
            RectPS(x1, y1, x2, y2, out P, out S);

            Console.WriteLine($"Периметр: {P}");
            Console.WriteLine($"Площадь: {S}");

            Console.ReadLine();
        }

        /// <summary>
        /// Вычисляет периметр и площадь прямоугольника по координатам его углов.
        /// </summary>
        /// <param name="x1">Координата x первого угла.</param>
        /// <param name="y1">Координата y первого угла.</param>
        /// <param name="x2">Координата x второго угла.</param>
        /// <param name="y2">Координата y второго угла.</param>
        /// <param name="P">Периметр прямоугольника.</param>
        /// <param name="S">Площадь прямоугольника.</param>
        static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            double width = Math.Abs(x2 - x1);
            double height = Math.Abs(y2 - y1);

            P = 2 * (width + height);
            S = width * height;
        }
    }
}
