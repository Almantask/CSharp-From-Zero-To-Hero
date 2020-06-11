using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Challenge
    {
        public static string LongestSubstring(string s)
        {
            if (s is null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var charArray = s.ToLower().ToCharArray();
            string returnString = "";

            foreach (char character in charArray)
            {
                if (!returnString.Contains(character))
                {
                    returnString += character;
                }
            }

            return returnString;
        }
    }
}
