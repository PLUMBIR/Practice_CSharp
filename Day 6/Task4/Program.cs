using System;
using System.Collections.Generic;

namespace Task4
{
    public class Program
    {
        static int GetAlphabetPosition(char letter)
        {
            if (char.IsLetter(letter))
            {
                char upperLetter = char.ToUpper(letter);

                Dictionary<char, int> russianAlphabet = new Dictionary<char, int>
                {
                    {'А', 1}, {'Б', 2}, {'В', 3}, {'Г', 4}, {'Д', 5}, {'Е', 6}, {'Ё', 7},
                    {'Ж', 8}, {'З', 9}, {'И', 10}, {'Й', 11}, {'К', 12}, {'Л', 13}, {'М', 14},
                    {'Н', 15}, {'О', 16}, {'П', 17}, {'Р', 18}, {'С', 19}, {'Т', 20}, {'У', 21},
                    {'Ф', 22}, {'Х', 23}, {'Ц', 24}, {'Ч', 25}, {'Ш', 26}, {'Щ', 27}, {'Ъ', 28},
                    {'Ы', 29}, {'Ь', 30}, {'Э', 31}, {'Ю', 32}, {'Я', 33}
                };

                if (russianAlphabet.ContainsKey(upperLetter))
                {
                    return russianAlphabet[upperLetter];
                }
            }
            return 0;
        }

        static int CalculateSingleDigit(int number)
        {
            while (number >= 10)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum;
            }
            return number;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите фамилию: ");
            string surname = Console.ReadLine();

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите отчество: ");
            string patronymic = Console.ReadLine();

            int sum = 0;
            foreach (char letter in (surname + name + patronymic))
            {
                sum += GetAlphabetPosition(letter);
            }

            int personalCode = CalculateSingleDigit(sum);

            Console.WriteLine($"Код личности: {personalCode}");

            Console.ReadLine();
        }
    }
}
