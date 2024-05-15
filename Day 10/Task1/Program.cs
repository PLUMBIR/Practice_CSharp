using System;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            Animal animal = new Animal("Лев", 1.2);
            Cat cat = new Cat("Мурка", 0.3, "Scottish Fold");

            Console.WriteLine("Информация о животном:");
            animal.DisplayInfo();
            Console.WriteLine($"Вес животного: {animal.CalculateWeight(10):F2} кг");

            Console.WriteLine("\nИнформация о кошке:");
            cat.DisplayInfo();
            Console.WriteLine($"Вес кошки: {cat.CalculateWeight(15):F2} г");

            Console.ReadLine();
        }
    }
}
