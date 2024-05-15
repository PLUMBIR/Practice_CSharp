using System;

class Program
{
    static void Main(string[] args)
    {
        Func<double, double, double> Add = (a, b) => a + b;
        Func<double, double, double> Sub = (a, b) => a - b;
        Func<double, double, double> Mul = (a, b) => a * b;
        Func<double, double, double> Div = (a, b) =>
        {
            if (b != 0)
                return a / b;
            else
            {
                Console.WriteLine("Ошибка: деление на ноль!");
                return double.NaN;
            }
        };

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
