using System;
using System.Collections.Generic;

namespace BootCamp.Homework
{
    public class MostCommonLetterFinder
    {
        public char Find(string sentence)
        {
            if (string.IsNullOrEmpty(sentence) || sentence == " ") throw new ArgumentNullException();
            
            var countSentenceLetters = CountLetters(sentence);
            var mostCommonLetter = ' ';
            var timesUsed = 0;

            foreach (var (letter, count) in countSentenceLetters)
            {
                if (count <= timesUsed) continue;
                timesUsed = count;
                mostCommonLetter = letter;
            }
            
            return mostCommonLetter;
        }

        private Dictionary<char, int> CountLetters(string sentence)
        {
            var countSentenceLetters = new Dictionary<char, int>();

            foreach (var letter in sentence)
            {
                if (countSentenceLetters.ContainsKey(letter))
                {
                    countSentenceLetters[letter]++;
                }
                else
                {
                    countSentenceLetters.Add(letter, 1);
                }
            }

            return countSentenceLetters;
        }
    }
}