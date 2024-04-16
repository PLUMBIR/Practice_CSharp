using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число M: ");
            int M = int.Parse(Console.ReadLine());

            Console.Write("Введите целое число N: ");
            int N = int.Parse(Console.ReadLine());

            int quotient = M / N;
            int remainder = M % N;

            if (remainder == 0)
            {
                Console.WriteLine($"Частное от деления: {quotient}");
            }
            else
            {
                Console.WriteLine($"{M} на {N} нацело не делится.");
            }

            Console.ReadLine();
        }
    }
}
