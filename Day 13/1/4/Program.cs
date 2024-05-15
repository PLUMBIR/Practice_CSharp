using System;

class Publisher
{
    public delegate void MyEventHandler();

    public event MyEventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke();
    }
}

class Observer1
{
    public void HandleEvent()
    {
        Console.WriteLine("Observer1: Получено уведомление об изменении события.");
    }
}

class Observer2
{
    public void HandleEvent()
    {
        Console.WriteLine("Observer2: Получено уведомление об изменении события.");
    }
}

class Observer3
{
    public void HandleEvent()
    {
        Console.WriteLine("Observer3: Получено уведомление об изменении события.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Publisher publisher = new Publisher();

        Observer1 observer1 = new Observer1();
        Observer2 observer2 = new Observer2();
        Observer3 observer3 = new Observer3();

        publisher.MyEvent += observer1.HandleEvent;
        publisher.MyEvent += observer2.HandleEvent;
        publisher.MyEvent += observer3.HandleEvent;

        publisher.RaiseEvent();

        Console.WriteLine("------");

        publisher.MyEvent -= observer2.HandleEvent;

        publisher.RaiseEvent();
    }
}
