using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentNullException("The sentence you gave was empty.");
            }

            return GetMostCommonLetterDic(sentence);
        }

        private static char GetMostCommonLetterDic(string sentence)
        {
            Dictionary<char, int> lettersDic = new Dictionary<char, int>();

            foreach (char letter in sentence)
            {
                if (lettersDic.ContainsKey(letter))
                {
                    lettersDic[letter] += 1;
                }
                else
                {
                    lettersDic.Add(letter, 1);
                }
            }

            char mostCommonLetter = ' ';
            int number = 0;

            foreach (KeyValuePair<char, int> key in lettersDic)
            {
                if (key.Value > number)
                {
                    mostCommonLetter = key.Key;
                    number = key.Value;
                }
            }
            return mostCommonLetter;
        }
    }
}