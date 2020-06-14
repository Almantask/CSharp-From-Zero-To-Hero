using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence)) throw new ArgumentNullException();

            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();

            foreach (var character in sentence)
            {
                if (char.IsWhiteSpace(character)) continue;

                IterateDictionary(character, keyValuePairs);
            }

            var highestValue = keyValuePairs.Values.Max();
            return FindFirstKeyByValue(keyValuePairs, highestValue);
        }

        private static void IterateDictionary(char input, Dictionary<char, int> dictionary)
        {
            if (dictionary.ContainsKey(input))
            {
                dictionary.TryGetValue(input, out int value);
                dictionary[input] = ++value;
            }
            else
            {
                dictionary.Add(input, 1);
            }
        }

        private static TKey FindFirstKeyByValue<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, TValue value)
        {
            foreach (var keyValuePair in dictionary)
            {
                if (EqualityComparer<TValue>.Default.Equals(keyValuePair.Value, value))
                {
                    return keyValuePair.Key;
                }
            }
            
            return default;
        }
    }
}