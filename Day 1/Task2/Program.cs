using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int ABC = int.Parse(Console.ReadLine());

            int B = (ABC % 100) / 10;
            int C = ABC % 10;
            int A = ABC / 100;

            int BCA = B * 100 + C * 10 + A;

            Console.WriteLine($"Полученное число: {BCA}");
        }
    }
}
