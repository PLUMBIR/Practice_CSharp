using System;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] income = new int[10, 12];

            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    income[i, j] = rand.Next(1000, 5000);
                }
            }

            int totalIncomeSeptember = 0;
            for (int i = 0; i < 10; i++)
            {
                totalIncomeSeptember += income[i, 8];
            }

            Console.Write("Введите заданное число: ");
            int targetIncome = int.Parse(Console.ReadLine());

            if (totalIncomeSeptember > targetIncome)
            {
                Console.WriteLine($"Общий доход фирмы в сентябре ({totalIncomeSeptember}) превысил заданное число ({targetIncome}).");
            }
            else
            {
                Console.WriteLine($"Общий доход фирмы в сентябре ({totalIncomeSeptember}) не превысил заданное число ({targetIncome}).");
            }

            Console.ReadLine();
        }
    }
}
