using System;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the price of a notebook (in rubles): ");
            float notebookPrice = float.Parse(Console.ReadLine());

            Console.Write("Enter the number of notebooks: ");
            int notebookCount = int.Parse(Console.ReadLine());

            Console.Write("Enter the price of a pencil (in rubles): ");
            float pencilPrice = float.Parse(Console.ReadLine());

            Console.Write("Enter the number of pencils: ");
            int pencilCount = int.Parse(Console.ReadLine());

            float totalCost = (notebookPrice * notebookCount) + (pencilPrice * pencilCount);

            Console.WriteLine($"Total purchase cost: {totalCost} rubles");

            Console.ReadLine();
        }
    }
}
