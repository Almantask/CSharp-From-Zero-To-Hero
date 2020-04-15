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

        private static char GetMostCommonLetter(string sentence)
        {
            int mostCommonLetterCount = 0;
            char mostCommonLetter = ' ';
            int nextLetterCount = 0;
            char nextLetter = ' ';

            List<char> sentenceList = new List<char>();
            foreach (char character in sentence)
            {
                sentenceList.Add(character);
            }
            sentenceList.Sort();

            foreach (char c in sentenceList)
            {
                if (c == nextLetter)
                {
                    nextLetterCount++;
                    if (c == sentenceList[sentenceList.Count - 1])
                    {
                        if (nextLetterCount == mostCommonLetterCount)
                        {
                            mostCommonLetter = FirstCharFound(sentence, mostCommonLetter, nextLetter);
                        }
                        else if (nextLetterCount > mostCommonLetterCount)
                        {
                            mostCommonLetterCount = nextLetterCount;
                            mostCommonLetter = nextLetter;
                        }
                    }
                }
                else
                {
                    if (nextLetterCount == mostCommonLetterCount)
                    {
                        mostCommonLetter = FirstCharFound(sentence, mostCommonLetter, nextLetter);
                    }
                    else if (nextLetterCount > mostCommonLetterCount)
                    {
                        mostCommonLetterCount = nextLetterCount;
                        mostCommonLetter = nextLetter;
                    }
                    nextLetterCount = 1;
                    nextLetter = c;
                    if (c == sentenceList[sentenceList.Count - 1] && nextLetterCount > mostCommonLetterCount)
                    {
                        mostCommonLetterCount = nextLetterCount;
                        mostCommonLetter = nextLetter;
                    }
                }
            }
            return mostCommonLetter;
        }

        private static char FirstCharFound(string originalSentence, char x, char y)
        {
            foreach (char letter in originalSentence)
            {
                if (letter == x)
                {
                    return x;
                }
                if (letter == y)
                {
                    return y;
                }
            }
            return ' ';
        }
    }
}