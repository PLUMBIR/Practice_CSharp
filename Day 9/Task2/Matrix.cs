using System;

namespace Task2
{
    class Matrix
    {
        private int[,] data;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        public void SetElement(int row, int col, int value)
        {
            data[row, col] = value;
        }

        public int GetElement(int row, int col)
        {
            return data[row, col];
        }

        public void DisplaySubmatrix(int startRow, int startCol, int endRow, int endCol)
        {
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void DisplayMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
