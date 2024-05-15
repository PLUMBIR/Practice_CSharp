using System;
using System.IO;

namespace Task2
{
    public class Program
    {
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
