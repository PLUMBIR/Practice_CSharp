using System;

namespace Task2
{
    public class Program
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

        static void RectPS(double x1, double y1, double x2, double y2, out double P, out double S)
        {
            double width = Math.Abs(x2 - x1);
            double height = Math.Abs(y2 - y1);

            P = 2 * (width + height);

            S = width * height;
        }


    }
}
