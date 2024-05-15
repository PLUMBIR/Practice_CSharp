using System;

class Program
{
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static string ConvertToUpperCase(string str)
    {
        return str.ToUpper();
    }

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
    }
}
