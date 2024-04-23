using System;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение для n (n >= 3): ");
            int n = int.Parse(Console.ReadLine());

            double result = CalculateF(n);
            if (!double.IsNaN(result))
            {
                Console.WriteLine($"f({n}) = {result}");
            }  
            else
            {
                Console.WriteLine("Ошибка: n должно быть больше или равно 3.");
            }

            Console.ReadLine();
        }

        static long Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        static double CalculateF(int n)
        {
            if (n < 3)
                return double.NaN;
            else
            {
                long numerator = Factorial(n - 3);
                long denominator = Factorial(n);
                return (double)numerator / denominator;
            }
        }
    }
}
