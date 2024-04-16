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
            char targetDigit = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            do
            {
                if (A % 10 == targetDigit)
                {
                    Console.WriteLine(A);
                }
                A++;
            } while (A <= B);

            Console.ReadLine();
        }
    }
}
