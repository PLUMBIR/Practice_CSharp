using System;

namespace Task3
{
    /// <summary>
    /// Класс для работы с матрицами.
    /// </summary>
    class Matrix
    {
        private int N { get; set; }
        private int M { get; set; }

        /// <summary>
        /// Конструктор класса Matrix.
        /// </summary>
        /// <param name="n">Количество строк.</param>
        /// <param name="m">Количество столбцов.</param>
        public Matrix(int n, int m)
        {
            N = n;
            M = m;
        }

        /// <summary>
        /// Вычитание строки из матрицы.
        /// </summary>
        /// <param name="a">Исходная матрица.</param>
        /// <param name="b">Номер строки для вычитания.</param>
        public void SubtractRow(double[,] a, int b)
        {
            double[,] c = new double[N, M];

            Console.WriteLine("Исходная матрица:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{a[i, j]} \t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (i != b)
                    {
                        c[i, j] = a[i, j] - a[b, j];
                    }
                    else
                    {
                        c[i, j] = a[i, j];
                    }
                }
            }

            Console.WriteLine("Матрица после вычитания строки:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write($"{c[i, j]} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
