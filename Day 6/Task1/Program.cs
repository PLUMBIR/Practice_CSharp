using System;
using System.Collections.Generic;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string inputText = Console.ReadLine();

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in inputText)
            {
                if (!char.IsWhiteSpace(c) && !char.IsPunctuation(c))
                {
                    char lowercaseChar = char.ToLower(c);

                    if (charFrequency.ContainsKey(lowercaseChar))
                        charFrequency[lowercaseChar]++;
                    else
                        charFrequency[lowercaseChar] = 1;
                }
            }

            Console.WriteLine("Частота символов:");
            foreach (var kvp in charFrequency)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            Console.ReadLine();
        }
    }
}
