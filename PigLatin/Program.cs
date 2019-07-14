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

            //Console.WriteLine(lilWord);

            string vowels = "aeiou";
            string pigWord;

            // If word begins with vowel, add -way
            if (vowels.Contains(lilWord[0]))
            {
                pigWord = string.Concat(word, "way");
            }

            // If begins with consonant, split at first vowel
            else
            {
                pigWord = "hello";
                for (int i = 1; i < word.Length; i++)
                {
                    if (vowels.Contains(lilWord[i]))
                    {
                        char c = lilWord[i];
                        string[] parts = lilWord.Split(lilWord[i]);
                        pigWord = string.Concat(c, parts[1], parts[0], "ay");
                        break;
                    }
                }
            }
            Console.WriteLine(pigWord);
        }
    }
}
