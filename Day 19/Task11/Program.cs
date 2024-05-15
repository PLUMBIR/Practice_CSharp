using System;
using System.IO;

namespace Task11
{
    /// <summary>
    /// Класс для создания папки "New_folder" на диске C:.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            string folderPath = @"C:\New_folder";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New_folder была успешно создана.");
            }
            else
            {
                Console.WriteLine("Папка уже существует.");
            }

            Console.ReadLine();
        }
    }
}
