using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task5
{
    public class Program
    {
        static void Main()
        {
            string path1 = "f1.txt";
            string path2 = "f2.txt";
            string path3 = "f3.txt";

            MergeFiles(path1, path2, path3);

            Console.ReadLine();
        }

        static void MergeFiles(string file1, string file2, string file3)
        {
            List<int> numbers = new List<int>();

            using (StreamReader sr = new StreamReader(file1))
            {
                int[] line = sr.ReadLine().Split(' ').Select(c => int.Parse(c)).ToArray();
                foreach(int i in line)
                {
                    numbers.Add(i);
                }
            }

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
