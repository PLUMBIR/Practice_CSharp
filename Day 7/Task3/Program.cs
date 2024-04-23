using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Task3
{
    public class Program
    {
        static void Main()
        {
            string text = "Эта книга адресована всем, кто изучает русский язык. Но состоит она не из правил, упражнений и учебных текстов. Для этого созданы другие замечательные учебники. У этой книги совсем иная задача. Она поможет вам научиться не только разговаривать, но и размышлять по-русски. Книга, которую вы держите в руках, составлена из афоризмов и размышлений великих мыслителей, писателей, поэтов, философов и общественных деятелей различных эпох. Их мысли - о тех вопросах, которые не перестают волновать человечество. Вы можете соглашаться или не соглашаться с тем, что прочитаете в этой книге. Возможно, вам покажется, что какие-то мысли уже устарели. Но вы должны обязательно подумать и обосновать, почему вы так считаете. А еще вы узнаете и почувствуете, как прекрасно звучат слова любви, сострадания, мудрости и доброты на русском языке.";

            string pattern = @"\b\w+\b";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

            var wordPairs = new List<(string, string)>();

            for (int i = 0; i < matches.Count - 1; i++)
            {
                string firstWord = matches[i].Value;
                string secondWord = matches[i + 1].Value;

                if (firstWord[firstWord.Length - 1] == secondWord[0])
                {
                    wordPairs.Add((firstWord, secondWord));
                }
            }

            foreach (var pair in wordPairs)
            {
                Console.WriteLine($"Пара: {pair.Item1} - {pair.Item2}");
            }

            Console.ReadLine();
        }
    }
}
