using System;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 7;

            int[,] matrix = new int[n, n];
            int num = 1;

            int rowStart = 0, rowEnd = n - 1;
            int colStart = 0, colEnd = n - 1;

            while (num <= n * n)
            {
                for (int i = colStart; i <= colEnd; i++)
                    matrix[rowStart, i] = num++;

                for (int i = rowStart + 1; i <= rowEnd; i++)
                    matrix[i, colEnd] = num++;

                for (int i = colEnd - 1; i >= colStart; i--)
                    matrix[rowEnd, i] = num++;

                for (int i = rowEnd - 1; i > rowStart; i--)
                    matrix[i, colStart] = num++;

                rowStart++;
                rowEnd--;
                colStart++;
                colEnd--;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
