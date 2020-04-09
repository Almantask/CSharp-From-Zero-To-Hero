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
                throw new ArgumentNullException();
            }

            List<char> sentenceList = new List<char>();
            foreach (char character in sentence)
            {
                sentenceList.Add(character);
            }
            sentenceList.Sort();

            return GetMostCommonLetter(sentence, sentenceList);
        }

        private static char GetMostCommonLetter(string originalSentence, List<char> sortedSentenceList)
        {
            int mostCommonLetterCount = 0;
            char mostCommonLetter = ' ';
            int nextLetterCount = 0;
            char nextLetter = ' ';

            foreach (char c in sortedSentenceList)
            {
                if (c == nextLetter)
                {
                    nextLetterCount++;
                    if (c == sortedSentenceList[sortedSentenceList.Count - 1])
                    {
                        if (nextLetterCount == mostCommonLetterCount)
                        {
                            mostCommonLetter = FirstCharFound(originalSentence, mostCommonLetter, nextLetter);
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
                        mostCommonLetter = FirstCharFound(originalSentence, mostCommonLetter, nextLetter);
                    }
                    else if (nextLetterCount > mostCommonLetterCount)
                    {
                        mostCommonLetterCount = nextLetterCount;
                        mostCommonLetter = nextLetter;
                    }
                    nextLetterCount = 1;
                    nextLetter = c;
                    if (c == sortedSentenceList[sortedSentenceList.Count - 1] && nextLetterCount > mostCommonLetterCount)
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