using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string inputText = Console.ReadLine();

            int product = 1;
            int minDigit = int.MaxValue;

            foreach (char c in inputText)
            {
                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());
                    product *= digit;
                    minDigit = Math.Min(minDigit, digit);
                }
            }

            Console.WriteLine($"Произведение цифр: {product}");
            Console.WriteLine($"Минимальная цифра: {minDigit}");

            Console.ReadLine();
        }
    }
}
