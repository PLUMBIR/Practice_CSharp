using System;

namespace Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            if ((a < -5 || a > 5) || (n < 1 || n > 10))
            {
                Console.WriteLine("Неверный ввод.");
            }
            else
            {
                double result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= a;
                    Console.WriteLine(result);
                }
            }

            Console.ReadKey();
        }
    }
}
