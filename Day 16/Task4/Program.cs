using System;
using System.IO;

namespace Task4
{
    public class Program
    {
        static void Main()
        {
            string file1Path = "file1.txt";
            string file2Path = "file2.txt";

            string[] file1Lines = File.ReadAllLines(file1Path);
            string[] file2Lines = File.ReadAllLines(file2Path);

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
