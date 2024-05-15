using System;

namespace Task1
{
    public class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("<< Тишина >>");
        }
    }
}
