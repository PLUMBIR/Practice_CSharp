using System;

namespace Task3
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.WriteLine("Введите размер матрицы (строки и столбцы):");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            Matrix matrix = new Matrix(n, m);

            double[,] a = new double[n, m];

            Console.WriteLine("Рандомное заполнение матрицы:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = rnd.NextDouble();
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите номер строки для вычитания:");
            int b = Convert.ToInt32(Console.ReadLine());

            matrix.SubtractRow(a, b);

            Console.ReadLine();
        }
    }
}
