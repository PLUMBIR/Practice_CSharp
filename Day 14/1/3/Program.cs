using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите число N: ");
        int N = int.Parse(Console.ReadLine());

        Thread threadSum1 = new Thread(() => Sum(A, N));
        Thread threadSum2 = new Thread(() => Sum(A, N));

        threadSum1.Start();
        threadSum2.Start();

        Multiply(A, N);
    }

    static void Sum(int A, int N)
    {
        long result = 0;
        for (int i = 1; i <= N; i++)
        {
            result += A;
            Thread.Sleep(100);
        }
        Console.WriteLine($"Сумма чисел {A} + {A} + ... + {A} (N раз) = {result}");
    }

    static void Multiply(int A, int N)
    {
        long result = 1;
        for (int i = 1; i <= N; i++)
        {
            result *= A;
            Thread.Sleep(100);
        }
        Console.WriteLine($"Произведение чисел {A} * {A} * ... * {A} (N раз) = {result}");
    }
}
