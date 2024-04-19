using System;

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Введите значение x: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Значение функции f: {CalculateFunction(x)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректный формат ввода.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadLine();
        }

        static double CalculateFunction(double x)
        {
            if (x <= -3)
            {
                return 5 * x;
            }
            else if (x > -3 && x < 3)
            {
                if (x == 0)
                {
                    throw new DivideByZeroException();
                }
                return 2 / x;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(x), "x не входит в диапазон допустимых значений.");
            }
        }
    }
}
