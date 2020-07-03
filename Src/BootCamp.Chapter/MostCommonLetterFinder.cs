using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            Dictionary<char, int> charsFromString = new Dictionary<char, int>();
            if (sentence == " " || sentence == "" || sentence == null) throw new ArgumentNullException("Input string is Empty");
            var sentenceNoWhiteSpace = sentence.Trim(' ');
            foreach (var character in sentenceNoWhiteSpace)
            {
                if (!charsFromString.ContainsKey(character))
                {
                    charsFromString.Add(character, 1);
                }
                else
                {
                    charsFromString[character]++;
                }
            }
            return FindMostCommonVal(charsFromString);
        }

        private static char FindMostCommonVal(Dictionary<char, int> dictionary)
        {
            var mostCommonVal = ' ';
            var letterCount = 0;
            foreach (var character in dictionary)
            {
                if (letterCount < character.Value)
                {
                    letterCount = character.Value;
                    mostCommonVal = character.Key;
                }       
            }
            return mostCommonVal;
        }
    }
}