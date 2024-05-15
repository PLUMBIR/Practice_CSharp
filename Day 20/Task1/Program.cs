using System;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите трехзначное число: ");
                int number = int.Parse(Console.ReadLine());

                if (number >= 1000 || number < 100)
                {
                    throw new ArgumentException("Число должно быть трехзначным");
                }

                Task task1 = Task.Factory.StartNew(() => PermuteNumber(number));
                //Task task2 = new(() => PermuteNumber(number));
                //task2.Start();
                Task task3 = Task.Run(() => PermuteNumber(number));

                // Ждем завершения всех задач
                Task.WaitAll(task1, task3);

                Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void PermuteNumber(int number)
        {
            int a1 = number % 100;
            int a1_1 = a1 / 10;
            int a1_2 = a1 % 10;
            int a2 = number / 100;

            int permutedNumber = a1_1 * 100 + a1_2 * 10 + a2;
            Console.WriteLine("Число, полученное при перестановке цифр: " + permutedNumber);
        }
    }
}
