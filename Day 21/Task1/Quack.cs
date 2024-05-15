using System;

namespace Task1
{
    public class Quack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Кря-кря");
        }
    }
}
