using System;
using System.IO;

namespace Task13
{
    /// <summary>
    /// Класс для сравнения строк в двух файлах.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Пути к файлам
            string file1Path = "file1.txt";
            string file2Path = "file2.txt";

            // Чтение строк из файлов
            string[] file1Lines = File.ReadAllLines(file1Path);
            string[] file2Lines = File.ReadAllLines(file2Path);

            // Проверка на равенство строк
            bool areEqual = true;
            int firstDifferentLine = -1;

            for (int i = 0; i < file1Lines.Length; i++)
            {
                if (file1Lines[i] != file2Lines[i])
                {
                    areEqual = false;
                    firstDifferentLine = i + 1;
                    break;
                }
            }

            // Вывод результата
            if (areEqual)
            {
                Console.WriteLine("Строки в файлах совпадают.");
            }
            else
            {
                Console.WriteLine($"Первая различающаяся строка на позиции {firstDifferentLine}.");
            }

            Console.ReadLine();
        }
    }
}
