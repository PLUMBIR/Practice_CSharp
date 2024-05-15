using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task14
{
    /// <summary>
    /// Класс для слияния данных из двух файлов в третий файл.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            string path1 = "f1.txt";
            string path2 = "f2.txt";
            string path3 = "f3.txt";

            MergeFiles(path1, path2, path3);

            Console.ReadLine();
        }

        /// <summary>
        /// Слияние данных из двух файлов в третий файл.
        /// </summary>
        /// <param name="file1">Путь к первому файлу.</param>
        /// <param name="file2">Путь ко второму файлу.</param>
        /// <param name="file3">Путь к третьему файлу (результирующему).</param>
        static void MergeFiles(string file1, string file2, string file3)
        {
            List<int> numbers = new List<int>();

            // Чтение данных из первого файла
            using (StreamReader sr = new StreamReader(file1))
            {
                int[] line = sr.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
                foreach (int i in line)
                {
                    numbers.Add(i);
                }
            }

            // Чтение данных из второго файла и слияние
            using (StreamReader sr = new StreamReader(file2))
            {
                int[] line = sr.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
                foreach (int i in line)
                {
                    int position = numbers.BinarySearch(i);
                    if (position < 0) position = ~position;
                    numbers.Insert(position, i);
                }
            }

            // Запись результата в третий файл
            using (StreamWriter sw = new StreamWriter(file3))
            {
                foreach (int number in numbers)
                {
                    sw.WriteLine(number);
                }
            }
        }
    }
}
