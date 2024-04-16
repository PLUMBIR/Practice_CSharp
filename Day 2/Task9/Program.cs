using System;

namespace Task9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите цифру k: ");
            int k = int.Parse(Console.ReadLine());

            int count = CountDigitOccurrences(n, k);
            Console.WriteLine($"Цифра {k} встречается в числе {n} {count} раз(а).");
        }

        static int CountDigitOccurrences(int number, int digit)
        {
            int count = 0;
            while (number != 0)
            {
                int currentDigit = number % 10;
                if (currentDigit == digit)
                    count++;
                number /= 10;
            }
            return count;
        }
    }
}
