using System;

namespace Task8
{
    /// <summary>
    /// Класс, содержащий методы для обработки строк.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод для обращения строки в обратном порядке.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns>Строка, обращенная в обратном порядке.</returns>
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        /// <summary>
        /// Метод для преобразования строки в верхний регистр.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns>Строка в верхнем регистре.</returns>
        static string ConvertToUpperCase(string str)
        {
            return str.ToUpper();
        }

        /// <summary>
        /// Метод для удаления пробелов из строки.
        /// </summary>
        /// <param name="str">Исходная строка.</param>
        /// <returns>Строка без пробелов.</returns>
        static string RemoveWhitespace(string str)
        {
            return str.Replace(" ", "");
        }

        delegate string StringDelegate(string str);

        static void Main(string[] args)
        {
            StringDelegate stringDelegate;

            stringDelegate = ReverseString;
            Console.WriteLine("Реверс строки: " + stringDelegate("Hello World"));

            stringDelegate = ConvertToUpperCase;
            Console.WriteLine("Строка в верхнем регистре: " + stringDelegate("Hello World"));

            stringDelegate = RemoveWhitespace;
            Console.WriteLine("Строка без пробелов: " + stringDelegate("Hello World"));

            Console.ReadLine();
        }
    }
}
