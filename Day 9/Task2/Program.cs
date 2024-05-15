using System;

namespace Task2
{
    public class Program
    {
        static void Main()
        {
            Matrix matrix = new Matrix(3, 4);
            matrix.SetElement(0, 0, 1);
            matrix.SetElement(0, 1, 2);
            matrix.SetElement(0, 2, 3);
            matrix.SetElement(0, 3, 4);
            matrix.SetElement(1, 0, 5);
            matrix.SetElement(1, 1, 6);
            matrix.SetElement(1, 2, 7);
            matrix.SetElement(1, 3, 8);
            matrix.SetElement(2, 0, 9);
            matrix.SetElement(2, 1, 10);
            matrix.SetElement(2, 2, 11);
            matrix.SetElement(2, 3, 12);

            Console.WriteLine("Полная матрица:");
            matrix.DisplayMatrix();

            Console.WriteLine("\nПодматрица (1, 1) до (2, 2):");
            matrix.DisplaySubmatrix(1, 1, 2, 2);

            Console.ReadLine();
        }
    }
}
