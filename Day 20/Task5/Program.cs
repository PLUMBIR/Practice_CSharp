using System;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 74, 23, 65, 98 };

            Parallel.ForEach(numbers, (number, state) =>
            {
                long sum = CalculateSum(number);
                long product = CalculateProduct(number);

                if (sum > 346 || product > 643)
                {
                    state.Stop();
                    Console.WriteLine("Прерывание выполнения параллельного вычисления.");
                    return;
                }

                Console.WriteLine($"Для числа {number}: Сумма = {sum}, Произведение = {product}");
            });

            Console.ReadLine();
        }

        static long CalculateSum(int n)
        {
            return (long)n * (n + 1) / 2;
        }

        static long CalculateProduct(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }

}
