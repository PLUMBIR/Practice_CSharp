using System;

namespace Task5
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите начальное значение А: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение В: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите цифру Х: ");
            int targetDigit = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if(targetDigit <= 9 && targetDigit >= 0)
            {
                for (int i = A; i <= B; i++)
                {
                    if (i % 10 == targetDigit)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
