using System;
using System.Security.Cryptography;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        /*

         Input: "Hello", 0
           +-----+
           |Hello|
           +-----+
           
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
           
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+

         */

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            if(message == "") { return ""; }
            StringBuilder result = new StringBuilder();
            string[] lines = message.Split(Environment.NewLine);
            int maxWordLength = lines[0].Length;
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Length > maxWordLength) { maxWordLength = lines[i].Length; }
            }
            result.Append(ReturnVerticalFrameLine(maxWordLength, padding));
            result.Append(ReturnContentLines(lines, maxWordLength, padding));
            result.Append(ReturnVerticalFrameLine(maxWordLength, padding));
            return result.ToString();
        }

        private static string ReturnContentLines(string[] lines, int maxWordLength, int padding)
        {
            StringBuilder result = new StringBuilder();
            
            for (int i = 0; i < padding; i++)
            {
                result.Append(ReturnVerticalEmptyLine(maxWordLength, padding));
            }
            for (int i = 0; i < lines.Length; i++)
            {
                result.Append("|");
                for (int j = 0; j < padding; j++)
                {
                    result.Append(" ");
                }
                result.Append(lines[i]);
                if(lines[i].Length < maxWordLength)
                {
                    result.Append(' ', maxWordLength - lines[i].Length);
                }
                result.Append(' ', padding);
                result.Append($"|{Environment.NewLine}");
            }
            for (int i = 0; i < padding; i++)
            {
                result.Append(ReturnVerticalEmptyLine(maxWordLength, padding));
            }
            return result.ToString();
        }

        private static string ReturnVerticalEmptyLine(int maxWordLength, int padding)
        {
            StringBuilder result = new StringBuilder();
            result.Append("|");
            for (int i = 0; i < maxWordLength + padding * 2; i++)
            {
                result.Append(" ");
            }
            result.Append("|");
            result.Append(Environment.NewLine);
            return result.ToString();
        }

        private static string ReturnVerticalFrameLine(int maxWordLength, int padding)
        {
            StringBuilder result = new StringBuilder();
            result.Append("+");
            for (int i = 0; i < maxWordLength + padding * 2; i++)
            {
                result.Append("-");
            }
            result.Append("+"); 
            result.Append(Environment.NewLine);
            return result.ToString();
        }
    }
}
