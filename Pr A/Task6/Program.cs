﻿using System;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 10;

            int secondDigit = number % 10;

            int sum = firstDigit + secondDigit;

            Console.WriteLine($"Сумма цифр числа {number} равна {sum}");

            Console.ReadLine();
        }
    }
}
