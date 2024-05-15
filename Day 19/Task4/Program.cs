using System;

namespace Task4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        static void Main()
        {
            // Ввод данных
            Console.Write("Введите a1: ");
            double a1 = double.Parse(Console.ReadLine());

            Console.Write("Введите b1: ");
            double b1 = double.Parse(Console.ReadLine());

            Console.Write("Введите a2: ");
            double a2 = double.Parse(Console.ReadLine());

            Console.Write("Введите b2: ");
            double b2 = double.Parse(Console.ReadLine());

            Console.Write("Введите c2: ");
            double c2 = double.Parse(Console.ReadLine());

            // Вычисление результата
            double result = Max(a1, b1) - Max(a2, b2, c2);

            // Вывод результата
            Console.WriteLine($"Результат: {result}");

            Console.ReadLine();
        }

        /// <summary>
        /// Возвращает максимальное значение из двух чисел.
        /// </summary>
        public static double Max(double a, double b)
        {
            return a > b ? a : b;
        }

        /// <summary>
        /// Возвращает максимальное значение из трех чисел.
        /// </summary>
        public static double Max(double a, double b, double c)
        {
            return Max(Max(a, b), c);
        }
    }
}
