using System;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var acc = new Accauntant();

            if (acc.AskForBonus(Post.Developer, 170))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
