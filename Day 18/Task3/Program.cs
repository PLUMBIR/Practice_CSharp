using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var prototype = new PrototypeClass<string>();
            prototype.Add("Элемент1");
            prototype.Add("Элемент2");

            Console.WriteLine("Оригинальный класс:");
            foreach (var item in prototype)
            {
                Console.WriteLine(item);
            }

            var clonedPrototype = prototype.Clone();
            clonedPrototype.Remove("Элемент1");

            Console.WriteLine("Клонированный класс:");
            foreach (var item in clonedPrototype)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
