using System;

namespace Task1
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehaviour = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("Я Кряква!");
        }
    }
}
