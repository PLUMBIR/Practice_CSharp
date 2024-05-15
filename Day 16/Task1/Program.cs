using System;
using System.IO;
using System.Linq;

namespace Task1
{
    public class Program
    {
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
