using System;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            A myObject = new A(10, 5);

            Console.WriteLine($"Значение частного a и b: {myObject.CalculateQuotient()}");
            Console.WriteLine($"Значение выражения 3 корня из a + b: {myObject.CalculateExpression()}");

            Console.ReadLine();
        }
    }
}
