using System;
using System.IO;

namespace Task3
{ 
    class Program
    {
        static void Main()
        {
            string filePath = "myFile.txt";
            File.WriteAllText(filePath, "First line\nSecond line\nThird line\nFourth line\nFifth line");

            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("File content:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            int lineCount = lines.Length;
            Console.WriteLine($"Number of lines: {lineCount}");

            foreach (string line in lines)
            {
                Console.WriteLine($"Number of characters in \"{line}\": {line.Length}");
            }

            string[] updatedLines = new string[lines.Length - 1];
            Array.Copy(lines, updatedLines, lines.Length - 1);

            File.WriteAllLines("newFile.txt", updatedLines);

            Console.WriteLine("Last line removed and saved to newFile.txt.");

            File.Delete(filePath);

            Console.ReadLine();
        }
    }      
}

