using System;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение аргумента А: ");
            double argA = double.Parse(Console.ReadLine());

            Task[] tasks = new Task[2];

            tasks[0] = Task.Factory.StartNew(() => Console.WriteLine(CalculateFirstFunction(argA)));
            tasks[1] = Task.Factory.StartNew(() => Console.WriteLine(CalculateSecondFunction(argA)));
            Task.WaitAll(tasks);
            Console.WriteLine("Все таски завершились");

            tasks[0] = Task.Factory.StartNew(() => Console.WriteLine(CalculateFirstFunction(argA)));
            tasks[1] = Task.Factory.StartNew(() => Console.WriteLine(CalculateSecondFunction(argA)));
            Task.WaitAny(tasks);
            Console.WriteLine("Хотя бы один таск завершился");

            Console.ReadLine();
        }

        static double CalculateFirstFunction(double alpha)
        {
            return (Math.Sin(alpha) + Math.Cos(2 * alpha - alpha)) / (Math.Cos(alpha) - Math.Sin(2 * alpha - alpha));
        }

        static double CalculateSecondFunction(double beta)
        {
            return (1 + Math.Sin(2 * beta)) / Math.Cos(2 * beta);
        }
    }
}
