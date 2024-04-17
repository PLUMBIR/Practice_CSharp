using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            const double x = 4.3;

            double y = (1 - Math.Sqrt(Math.Abs(3 - Math.Pow(x, 2)))) / Math.Atan(Math.Pow(x, 2)) - Math.Pow(Math.E, Math.Sin(Math.Sqrt(x)));

            Console.WriteLine(y);

            Console.ReadLine();
        }
    }
}
