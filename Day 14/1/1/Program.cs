using System;
using System.Threading;

class Program
{
    static AutoResetEvent event1 = new AutoResetEvent(false);
    static AutoResetEvent event2 = new AutoResetEvent(false);

    static void Main(string[] args)
    {
        Thread thread1 = new Thread(PrintNumbers);
        Thread thread2 = new Thread(PrintNumbers);
        Thread thread3 = new Thread(PrintNumbers);

        thread1.Name = "Поток 1";
        thread2.Name = "Поток 2";
        thread3.Name = "Поток 3";

        thread1.Priority = ThreadPriority.Highest;
        thread2.Priority = ThreadPriority.AboveNormal;
        thread3.Priority = ThreadPriority.Lowest;

        thread1.Start(0);
        thread2.Start(10);
        thread3.Start(20);

        thread1.Join();
        thread2.Join();
        thread3.Join();
    }

    static void PrintNumbers(object start)
    {
        int num = (int)start;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {num + i}");

            if (Thread.CurrentThread.Name == "Поток 1")
                event1.Set();
            else if (Thread.CurrentThread.Name == "Поток 2")
                event2.Set();

            if (i < 9)
            {
                if (Thread.CurrentThread.Name == "Поток 1")
                    event2.WaitOne();
                else if (Thread.CurrentThread.Name == "Поток 2")
                    event1.WaitOne();
            }
        }
    }
}
