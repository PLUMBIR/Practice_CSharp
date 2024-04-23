using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер матрицы N (N < 10): ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите нижнюю границу диапазона (a): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите верхнюю границу диапазона (b): ");
            int b = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];
            Random rand = new Random();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = rand.Next(a, b + 1);
                }
            }

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Введите значение С: ");
            int C = int.Parse(Console.ReadLine());
            int sumOfSquares = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] > C)
                    {
                        sumOfSquares += matrix[i, j] * matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Сумма квадратов элементов, больших {C}, равна: {sumOfSquares}");

            for (int i = 0; i < N; i++)
            {
                int rowSum = 0;
                for (int j = 0; j < N; j++)
                {
                    rowSum += matrix[i, j];
                }
                double average = (double)rowSum / N;
                Console.WriteLine($"Среднее арифметическое элементов строки {i + 1}: {average}");
            }

            Console.ReadLine();
        }
    }
}
