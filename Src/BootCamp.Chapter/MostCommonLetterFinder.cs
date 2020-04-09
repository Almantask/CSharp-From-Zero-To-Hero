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
            int number = 0;
            char letter = ' ';
            int runnerupNumber = 0;
            char runnerupLetter = ' ';
            List<char> sentenceList = new List<char>();

            foreach (char character in sentence)
            {
                sentenceList.Add(character);
            }
            sentenceList.Sort();
            foreach (char c in sentenceList)
            {
                //TODO if at end of the list does not add the letter.
                if (c == runnerupLetter)
                {
                    runnerupNumber++;
                    if (c == sentenceList[sentenceList.Count -1])
                    {
                        if (runnerupNumber == number)
                        {
                            letter = FirstCharFound(sentence, letter, runnerupLetter);
                        }
                        else if (runnerupNumber > number)
                        {
                            number = runnerupNumber;
                            letter = runnerupLetter;
                        }
                    }
                }
                else
                {
                    if (runnerupNumber == number)
                    {
                        letter = FirstCharFound(sentence, letter, runnerupLetter);
                    }
                    else if (runnerupNumber > number)
                    {
                        number = runnerupNumber;
                        letter = runnerupLetter;
                    }
                    runnerupNumber = 1;
                    runnerupLetter = c;
                    if (c == sentenceList[sentenceList.Count - 1] && runnerupNumber > number)
                    {
                        number = runnerupNumber;
                        letter = runnerupLetter;
                    }
                }
            }

            return letter;
        }
        private static char FirstCharFound(string sentence, char x, char y)
        {
            foreach (char letter in sentence)
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