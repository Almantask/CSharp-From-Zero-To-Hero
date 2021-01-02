using System;
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
            if (string.IsNullOrEmpty(message))
            {
                return "";
            }
            string[] textSplit = message.Split(new string[] { System.Environment.NewLine }, System.StringSplitOptions.None);
            StringBuilder textTable = new StringBuilder();

                int maxIndex = GetMaxIndex(textSplit);
                int iOne;

            textTable.Append("+").Append('-', textSplit[maxIndex].Length + padding * 2).AppendLine("+");
            for (iOne = 0; iOne < padding; iOne++)
            {
                textTable.Append("|").Append(' ', textSplit[maxIndex].Length + padding * 2).AppendLine("|");
            }
            for (iOne = 0; iOne < textSplit.Length; iOne++)
            {
                textTable.Append("|").Append(' ', padding).Append(textSplit[iOne]);
                textTable.Append(' ', textSplit[maxIndex].Length - textSplit[iOne].Length);
                textTable.Append(' ', padding).AppendLine("|");
            }
            for (iOne = 0; iOne < padding; iOne++)
            {
                textTable.Append("|").Append(' ', textSplit[maxIndex].Length + padding * 2).AppendLine("|");
            }
            textTable.Append("+").Append('-', textSplit[maxIndex].Length + padding * 2).AppendLine("+");

                return textTable.ToString();
        }
        public static int GetMaxIndex(string[] message)
        {
                int iTwo, Max, GetIndex;
                GetIndex = 0;
                Max = 0;

            if (message.Length == 1) return 0;
                
            for (iTwo = 0; iTwo < message.Length; iTwo++)
            {
                if (message[iTwo].Length > Max)
                {
                    Max = message[iTwo].Length;
                    GetIndex = iTwo;
                }
            }
            return GetIndex;
        }
    }
}