using System;

namespace Task8
{
    public class Program
    {
        static void Main()
        {
            double A = 0;
            double B = Math.PI / 4;
            int M = 10;
            double H = (B - A) / M;

            for (int i = 0; i <= M; i++)
            {
                double x = A + i * H;
                double y = Math.Tan(x);
                Console.WriteLine($"x = {x:F2}, F(x) = {y:F4}");
            }
        }
    }
}
