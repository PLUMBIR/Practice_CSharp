using System;

namespace Task7
{
    /// <summary>
    /// Класс, содержащий методы для выполнения арифметических операций.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод для сложения двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат сложения.</returns>
        static double Add(double a, double b) => a + b;

        /// <summary>
        /// Метод для вычитания одного числа из другого.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат вычитания.</returns>
        static double Sub(double a, double b) => a - b;

        /// <summary>
        /// Метод для умножения двух чисел.
        /// </summary>
        /// <param name="a">Первое число.</param>
        /// <param name="b">Второе число.</param>
        /// <returns>Результат умножения.</returns>
        static double Mul(double a, double b) => a * b;

        /// <summary>
        /// Метод для деления одного числа на другое.
        /// </summary>
        /// <param name="a">Делимое число.</param>
        /// <param name="b">Делитель.</param>
        /// <returns>Результат деления.</returns>
        static double Div(double a, double b)
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return double.NaN;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Выберите операцию (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = Add(num1, num2);
                    break;
                case '-':
                    result = Sub(num1, num2);
                    break;
                case '*':
                    result = Mul(num1, num2);
                    break;
                case '/':
                    result = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("Ошибка: неверная операция!");
                    break;
            }

            Console.WriteLine($"Результат: {result}");
        }
    }
}
