using System;
using System.IO;
using System.Linq;

namespace Task15
{
    /// <summary>
    /// Класс для обработки файлов.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            string inputPath = "input.txt";
            string outputPath1 = "output1.txt";
            string outputPath2 = "output2.txt";
            string outputPath3 = "output3.txt";
            string outputPath4 = "output4.txt";
            int lineCount = 0;

            var linesWithNumbers = File.ReadAllLines(inputPath)
                                       .Select(line => $"{line} {++lineCount} {line.Length}")
                                       .ToList();
            File.WriteAllLines(outputPath1, linesWithNumbers);

            int lengthThreshold = 5;
            var longLines = File.ReadAllLines(inputPath)
                                .Where(line => line.Length > lengthThreshold)
                                .ToList();
            File.WriteAllLines(outputPath2, longLines);

            var evenLengthLines = File.ReadAllLines(inputPath)
                                      .Where(line => line.Length % 2 == 0)
                                      .ToList();
            File.WriteAllLines(outputPath3, evenLengthLines);

            var linesWithRemovedChars = File.ReadAllLines(inputPath)
                                            .Select(line => new string(line.Where((ch, index) => index % 2 != 0).ToArray()))
                                            .ToList();
            File.WriteAllLines(outputPath4, linesWithRemovedChars);

            Console.ReadLine();
        }
    }
}
