using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            double[] arr = new double[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.NextDouble() * 10;
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    arr[i] += 0.5;
                }
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            double average = sum / n;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 0 && arr[i] < average)
                {
                    arr[i] = 0.1;
                }
            }

            Array.Sort(arr);

            Console.WriteLine("Отсортированный массив:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Введите число k: ");
            double k = double.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, k);
            if (index >= 0)
            {
                Console.WriteLine($"Число {k} найдено в массиве на позиции {index}.");
            }
            else
            {
                Console.WriteLine($"Число {k} не найдено в массиве.");
            }

            Console.ReadLine();
        }
    }
}
