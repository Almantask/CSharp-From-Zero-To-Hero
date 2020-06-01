using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) throw new ArgumentNullException();
                Dictionary<char, int> testCollection = StringToCollection(sentence);
            return FindMostCommonLetter(testCollection);
        }

        private static Dictionary<char, int> StringToCollection(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i < charArray.Length; i++)
            {
                char letter = charArray[i];
                if (dictionary.ContainsKey(letter))
                {
                    dictionary[letter] = dictionary[letter] + 1;
                    continue;
                }
                dictionary.Add(charArray[i], 0);
            }

            return dictionary;
        }

        private static char FindMostCommonLetter(Dictionary<char, int> collection)
        {
            int maxRepetitions = -1;
            char mostCommonLetter = '\0';
            foreach (KeyValuePair<char, int> keyValuePair in collection)
            {
                if (keyValuePair.Value > maxRepetitions)
                {
                    maxRepetitions = keyValuePair.Value;
                    mostCommonLetter = keyValuePair.Key;
                }
            }

            return mostCommonLetter;
        }
    }
}