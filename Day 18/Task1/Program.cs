using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        static void Main()
        {
            string input = "abc###asd";
            Console.WriteLine("Исходная строка: " + input);
            Console.WriteLine("Преобразованная строка: " + TransformString(input));

            Console.ReadLine();
        }

        static string TransformString(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c == '#')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return new string(stack.ToArray());
        }
    }
}
