using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    public class Program
    {
        static void Main()
        {
            string filePath = "numbers.txt";
            int a = 10;
            int b = 20;

            Queue<int> intervalQueue = new Queue<int>();
            Queue<int> lessThanAQueue = new Queue<int>();
            Queue<int> greaterThanBQueue = new Queue<int>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    int number = int.Parse(reader.ReadLine());
                    if (number >= a && number <= b)
                    {
                        intervalQueue.Enqueue(number);
                    }
                    else if (number < a)
                    {
                        lessThanAQueue.Enqueue(number);
                    }
                    else
                    {
                        greaterThanBQueue.Enqueue(number);
                    }
                }
            }

            Console.WriteLine("Numbers in the interval [{0}, {1}]:", a, b);
            PrintQueue(intervalQueue);

            Console.WriteLine("Numbers less than {0}:", a);
            PrintQueue(lessThanAQueue);

            Console.WriteLine("Numbers greater than {0}:", b);
            PrintQueue(greaterThanBQueue);

            Console.ReadLine();
        }

        static void PrintQueue(Queue<int> queue)
        {
            foreach (int number in queue)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
