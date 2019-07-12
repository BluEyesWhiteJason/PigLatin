using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the word to be translated: ");

            string word = Console.ReadLine();

            string lilWord = word.ToLower();

            Console.WriteLine(lilWord);

            string vowels = "aeiou";
            string pigWord;

            if (vowels.Contains(lilWord[0]))
            {
                pigWord = string.Concat(word, "way");
            }
            else
            {
                pigWord = "ayy";
            }
            Console.WriteLine(pigWord);
        }
    }
}
