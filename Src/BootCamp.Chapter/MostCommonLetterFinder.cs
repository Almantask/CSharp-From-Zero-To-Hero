using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class MostCommonLetterFinder
    {
        public static char Find(string sentence)
        {
            if (string.IsNullOrEmpty(sentence)|| sentence == " ")
                throw new ArgumentNullException();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach(char ch in sentence)
            {
                if (dict.ContainsKey(ch))
                    dict[ch]++;
                else
                {
                    dict.Add(ch, 1);
                }
            }
            char maxLetter = ' ';
            int maxNumber = 0;
            foreach (var item in dict)
            {
                if(item.Value > maxNumber)
                {
                    maxLetter = item.Key;
                    maxNumber = item.Value;
                }                
            }
            return maxLetter;
        }
    }
}