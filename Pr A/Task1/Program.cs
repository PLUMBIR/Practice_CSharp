using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое вещественное число: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе вещественное число: ");
            double number2 = double.Parse(Console.ReadLine());

            double product = number1 * number2;

            Console.WriteLine($"Произведение чисел: {product:F1}");

            Console.ReadLine();
        }
    }
}
