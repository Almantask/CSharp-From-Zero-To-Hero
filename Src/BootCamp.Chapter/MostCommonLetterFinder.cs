using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            Dictionary<char, int> histogram = new Dictionary<char, int>();

            if (string.IsNullOrWhiteSpace(sentence))
            {
                throw new ArgumentNullException();
            }

            CountEachLetter(sentence, histogram);
            KeyValuePair<char, int> max = FindMostCommonLetter(histogram);

            return max.Key;

        }

        private static KeyValuePair<char, int> FindMostCommonLetter(Dictionary<char, int> histogram)
        {
            var max = default(KeyValuePair<char, int>);
            foreach (var item in histogram)
            {
                if (item.Value > max.Value)
                {
                    max = item;
                }
            }

            return max;
        }

        private static void CountEachLetter(string sentence, Dictionary<char, int> histogram)
        {
            foreach (var character in sentence)
            {
                if (histogram.ContainsKey(character))
                {
                    histogram[character] += 1;
                }
                else
                {
                    histogram[character] = 1;
                }
                ;
            }
        }
    }
}