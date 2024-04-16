using System;

namespace Task4
{
    public class Program
    {
        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static void Main()
        {

            Console.Write("Введите координаты точки A (xA, yA): ");
            double xA = double.Parse(Console.ReadLine());
            double yA = double.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки B (xB, yB): ");
            double xB = double.Parse(Console.ReadLine());
            double yB = double.Parse(Console.ReadLine());

            Console.Write("Введите координаты точки C (xC, yC): ");
            double xC = double.Parse(Console.ReadLine());
            double yC = double.Parse(Console.ReadLine());

            double AB = Distance(xA, yA, xB, yB);
            double BC = Distance(xB, yB, xC, yC);
            double AC = Distance(xA, yA, xC, yC);

            double perimeter = AB + BC + AC;
            double p = perimeter / 2;
            double area = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));

            Console.WriteLine($"Периметр треугольника P = {perimeter}");
            Console.WriteLine($"Площадь треугольника S = {area}");

            Console.ReadLine();
        }
    }
}
