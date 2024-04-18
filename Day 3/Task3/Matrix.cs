using System;

namespace Task3
{
    class Matrix
    {
        private int N {  get; set; }
        private int M { get; set; }

        public Matrix(int n, int m)
        {
            N = n;
            M = m;
        }

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
                for (int j = 0; j <M; j++)
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
