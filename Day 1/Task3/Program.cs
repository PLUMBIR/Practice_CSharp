using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите признак транспортного средства (a - автомобиль, в - велосипед, м - мотоцикл, с - самолет, п - поезд): ");
            char transportType = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            int maxSpeed = 0;

            switch (transportType)
            {
                case 'a':
                    maxSpeed = 200;
                    break;
                case 'в':
                    maxSpeed = 30;
                    break;
                case 'м':
                    maxSpeed = 150; 
                    break;
                case 'с':
                    maxSpeed = 900; 
                    break;
                case 'п':
                    maxSpeed = 300; 
                    break;
                default:
                    Console.WriteLine("Неверный признак транспортного средства.");
                    return;
            }

            Console.WriteLine($"Максимальная скорость транспортного средства: {maxSpeed} км/ч");

            Console.ReadLine();
        }
    }
}
