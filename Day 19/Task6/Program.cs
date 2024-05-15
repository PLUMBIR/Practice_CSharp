using System;

delegate double CalcFigure(double radius);

namespace Task6
{
    /// <summary>
    /// Класс, представляющий вычисление характеристик фигуры.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Вычисляет длину окружности для заданного радиуса.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <returns>Длина окружности.</returns>
        static double Get_Length(double radius)
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Вычисляет площадь круга для заданного радиуса.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        /// <returns>Площадь круга.</returns>
        static double Get_Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Вычисляет объем шара для заданного радиуса.
        /// </summary>
        /// <param name="radius">Радиус шара.</param>
        /// <returns>Объем шара.</returns>
        static double Get_Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }

        static void Main(string[] args)
        {
            CalcFigure CF;

            CF = Get_Length;
            Console.WriteLine("Длина окружности: " + CF(5));

            CF = Get_Area;
            Console.WriteLine("Площадь круга: " + CF(5));

            CF = Get_Volume;
            Console.WriteLine("Объем шара: " + CF(5));
        }
    }
}
