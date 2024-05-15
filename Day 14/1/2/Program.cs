using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Thread thread1 = new Thread(CalculateSum);
        Thread thread2 = new Thread(CalculateSum);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }

    static void CalculateSum()
    {
        long startTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }

        long endTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

        long elapsedTime = endTime - startTime;

        Console.WriteLine($"Поток {Thread.CurrentThread.ManagedThreadId}: Сумма чисел от 1 до 10 = {sum}, Затраченное время: {elapsedTime} мс");
    }
}
