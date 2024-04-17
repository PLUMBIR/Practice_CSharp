using System;

namespace Task7
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = int.Parse(Console.ReadLine());

            var z1 = (Math.Sin(a) + Math.Cos(2 * b - a)) / Math.Cos(a) - Math.Sin(2 * b - a);

            var z2 = 1 + Math.Sin(2 * b) / Math.Cos(2 * b);

            Console.WriteLine($"z1 = {z1}");
            Console.WriteLine($"z2 = {z2}");

            Console.ReadLine();
        }
    }
}
