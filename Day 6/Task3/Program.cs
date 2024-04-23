using System;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            string temp = words[0];
            words[0] = words[words.Length - 1];
            words[words.Length - 1] = temp;

            words[1] += words[2];

            char[] thirdWord = words[2].ToCharArray();
            Array.Reverse(thirdWord);
            string reversedThirdWord = new string(thirdWord);

            words[0] = words[0].Substring(2);

            Console.WriteLine("Результаты:");
            Console.WriteLine($"Поменяли местами первое и последнее слова: {string.Join(" ", words)}");
            Console.WriteLine($"Склеили второе и третье слова: {words[1]}");
            Console.WriteLine($"Третье слово в обратном порядке: {reversedThirdWord}");
            Console.WriteLine($"Первое слово без первых двух букв: {words[0]}");

            Console.ReadLine();
        }
    }
}
