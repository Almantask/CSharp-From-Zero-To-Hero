using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        static Dictionary<char, int> letterCount = new Dictionary<char, int>();
        static int maxCount = 0;

        public static char Find(string sentence)
        {
            if (sentence != null)
            {
                sentence = sentence.Trim();
            }

            if (string.IsNullOrEmpty(sentence))
            {
                throw new System.ArgumentNullException();
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if(sentence[i] == ' ')
                {
                    continue;
                }

                if (letterCount.ContainsKey(sentence[i]))
                {
                    letterCount[sentence[i]] += 1;
                }
                else
                {
                    letterCount.Add(sentence[i], 1);
                }
            }

            int count = 0;
            char letter = ' ';

            foreach (var item in letterCount)
            {
                if(item.Value > count)
                {
                    count = item.Value;
                    letter = item.Key;
                }
            }

            letterCount.Clear();
            maxCount = count;

            return letter;
        }

        public static void CharCountApp()
        {
            string input;

            do
            {
                Console.Write("Input sentence to check or press enter to quit: ");
                input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                Console.WriteLine($"The most common symbol is \"{Find(input)}\" {maxCount} times.");

                maxCount = 0;
            } while (true);
        }
    }
}