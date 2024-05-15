using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите 2-х число:");
                int number = int.Parse(Console.ReadLine());

                if (number >= 100 || number < 10)
                {
                    throw new ArgumentException("Число должно быть 2-х значным");
                }

                Task<int> permutationTask = Task.Factory.StartNew(() => PermuteNumber(number));
                Task continuationTask = permutationTask.ContinueWith(task => PrintPermutations(task.Result));

                continuationTask.Wait();

                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        static int PermuteNumber(int number)
        {
            return (number / 10) + (number % 10);
        }

        static void PrintPermutations(int number)
        {
            Console.WriteLine(number);
        }
    }
}
