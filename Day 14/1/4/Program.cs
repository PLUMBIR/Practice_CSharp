using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int threadCount = 4;
        int[] partialSums = new int[threadCount];

        Thread[] threads = new Thread[threadCount];
        for (int i = 0; i < threadCount; i++)
        {
            int index = i;
            threads[i] = new Thread(() =>
            {
                partialSums[index] = CalculatePartialSum(numbers, index, threadCount);
            });
            threads[i].Start();
        }

        foreach (var thread in threads)
        {
            thread.Join();
        }

        int totalSum = 0;
        foreach (var sum in partialSums)
        {
            totalSum += sum;
        }

        Console.WriteLine($"Сумма четных чисел в массиве: {totalSum}");
    }

    static int CalculatePartialSum(int[] numbers, int startIndex, int step)
    {
        int partialSum = 0;
        for (int i = startIndex; i < numbers.Length; i += step)
        {
            if (numbers[i] % 2 == 0)
            {
                partialSum += numbers[i];
            }
        }
        return partialSum;
    }
}
