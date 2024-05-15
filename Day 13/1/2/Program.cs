using System;

class Program
{
    static int CalculateSquarePerimeter(int side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона квадрата должна быть положительным числом.");

        return 4 * side;
    }

    static double CalculateSquareArea(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона квадрата должна быть положительным числом.");

        return side * side;
    }

    static void PrintTriangleSide(double side)
    {
        if (side <= 0)
            throw new ArgumentException("Сторона треугольника должна быть положительным числом.");

        Console.WriteLine($"Длина стороны треугольника: {side}");
    }

    static void PerformCalculations(CalculateDelegate calculateDelegate, double side)
    {
        calculateDelegate(side);
    }

    delegate void CalculateDelegate(double side);

    static void Main(string[] args)
    {
        try
        {
            CalculateDelegate calculateDelegate = null;

            calculateDelegate += (side) => Console.WriteLine($"Периметр квадрата: {CalculateSquarePerimeter((int)side)}");
            calculateDelegate += (side) => Console.WriteLine($"Площадь квадрата: {CalculateSquareArea(side)}");
            calculateDelegate += PrintTriangleSide;

            PerformCalculations(calculateDelegate, 5);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
