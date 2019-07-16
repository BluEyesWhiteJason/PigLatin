using System;

namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                Console.Write("Enter the word to be translated: ");

                string word = Console.ReadLine();

                if (word != "")
                {

                    string lilWord = word.ToLower();

                    //skip if contains numbers
                    bool skip = false;

                    foreach (char letter in word)
                    {
                        if (ContainsNum(letter))
                        {
                            skip = true;
                            break;
                        }
                    }
                    string vowels = "aeiou";

                    if (skip == false)
                    {
                        // If word begins with vowel, add -way
                        if (IsVowel(lilWord[0]))
                        {
                            Console.WriteLine(word + "way");
                        }

                        // If begins with consonant, split at first vowel
                        else
                        {
                            for (int i = 1; i < word.Length; i++)
                            {
                                if (vowels.Contains(lilWord[i]))
                                {
                                    string prefix = word.Substring(i);
                                    string postfix = word.Substring(0, i) + "ay";

                                    Console.WriteLine(prefix + postfix);
                                    break;
                                }
                            }
                        }
                        //Console.WriteLine(pigWord);
                        Console.WriteLine("Continue? y/n : ");
                        string contEnter = Console.ReadLine();

                        // Check if they want to continue
                        if (contEnter == "y" || contEnter == "Y")
                        {
                            cont = true;
                        }
                        else if (contEnter == "n" || contEnter == "N")
                        {
                            cont = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Your input contains a forbidden character");
                    }
                }
                else
                {
                    Console.WriteLine("Your input was empty, please try again");
                }
            }
        }

        public static bool IsVowel(Char c)
        {
            string vowels = "aeiou";

            bool output = vowels.Contains(c);
            return output;
        }

        public static bool ContainsNum(Char c)
        {
            bool output = char.IsNumber(c);
            return output;
        }
    }
}
