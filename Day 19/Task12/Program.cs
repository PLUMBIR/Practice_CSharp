using System;
using System.IO;

namespace Task12
{
    /// <summary>
    /// Класс для работы с файлами.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Создание файла и запись в него строк
            string filePath = "myFile.txt";
            File.WriteAllText(filePath, "First line\nSecond line\nThird line\nFourth line\nFifth line");

            // Чтение строк из файла
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Содержимое файла:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            // Количество строк
            int lineCount = lines.Length;
            Console.WriteLine($"Количество строк: {lineCount}");

            // Количество символов в каждой строке
            foreach (string line in lines)
            {
                Console.WriteLine($"Количество символов в \"{line}\": {line.Length}");
            }

            // Удаление последней строки и сохранение в новый файл
            string[] updatedLines = new string[lines.Length - 1];
            Array.Copy(lines, updatedLines, lines.Length - 1);
            File.WriteAllLines("newFile.txt", updatedLines);
            Console.WriteLine("Последняя строка удалена и сохранена в newFile.txt.");

            // Удаление исходного файла
            File.Delete(filePath);

            Console.ReadLine();
        }
    }
}
