using System;

namespace Task9
{

    /// <summary>
    /// Программа для вычисления среднего арифметического случайных чисел.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Делегат для генерации случайных чисел.
        /// </summary>
        /// <returns>Случайное число.</returns>
        delegate int RandomDelegate();

        static void Main(string[] args)
        {
            RandomDelegate[] delegatesArray = new RandomDelegate[]
            {
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100),
            () => new Random().Next(1, 100)
            };

            Func<RandomDelegate[], double> averageMethod = delegate (RandomDelegate[] delegates)
            {
                double sum = 0;
                foreach (var del in delegates)
                {
                    sum += del();
                }
                return sum / delegates.Length;
            };

            Console.WriteLine($"Среднее арифметическое: {averageMethod(delegatesArray)}");
        }
    }
}
