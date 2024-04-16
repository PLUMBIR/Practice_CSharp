using System;

namespace Task6
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите начальное значение А: ");
            int A = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение В: ");
            int B = int.Parse(Console.ReadLine());

            Console.Write("Введите цифру Х или У: ");
            int targetDigit = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (targetDigit <= 9 && targetDigit >= 0)
            {
                do
                {
                    if (A % 10 == targetDigit)
                    {
                        Console.WriteLine(A);
                    }
                    A++;
                } while (A <= B);
            }

            Console.ReadLine();
        }
    }
}
