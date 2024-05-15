using System;

namespace Task1
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Я не могу летать");
        }
    }
}
