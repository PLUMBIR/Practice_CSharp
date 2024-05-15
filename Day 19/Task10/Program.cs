using System;
using System.IO;
using System.Linq;

namespace Task10
{
    /// <summary>
    /// Класс для вычисления суммы максимального и минимального компонентов из файла.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            string filePath = @"input.txt";
            string fileContent = File.ReadAllText(filePath);

            string[] componentStrings = fileContent.Split(' ');
            double[] components = componentStrings.Select(s => double.Parse(s)).ToArray();

            double maxComponent = components.Max();
            double minComponent = components.Min();

            double sum = maxComponent + minComponent;

            Console.WriteLine($"Сумма: {sum}");

            Console.ReadLine();
        }
    }
}
