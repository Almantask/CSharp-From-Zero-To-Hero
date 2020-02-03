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
            // make a array so I can find the longest word. 

            var arrayOfLines = message.Split(Environment.NewLine);

            // Find length of longest word 
            var lengthLongestWord = GetLongestWordLength(arrayOfLines);

            // print table 

            var table = new StringBuilder();
            AddTopOrBottomLineToTable(padding, lengthLongestWord, table);
            AddEmptyLinesToTable(padding, lengthLongestWord, table);
            AddTextToTable(padding, arrayOfLines, lengthLongestWord, table);
            AddEmptyLinesToTable(padding, lengthLongestWord, table);
            AddTopOrBottomLineToTable(padding, lengthLongestWord, table);
            return table.ToString();

        }

        private static void AddTextToTable(int padding, string[] arrayOfLines, int lengthLongestWord, StringBuilder table)
        {
            foreach (var word in arrayOfLines)
            {
                table.Append("|");
                table.Append(String.Empty.PadRight(padding, ' '));
                table.Append(word);
                table.Append(String.Empty.PadRight(lengthLongestWord - word.Length + padding, ' '));
                table.Append("|");
                table.Append(Environment.NewLine);

            }

        }

        private static int GetLongestWordLength(string[] arrayOfLines)
        {
            var lengthLongestWord = 0;
            foreach (var word in arrayOfLines)
            {
                if (word.Length > lengthLongestWord)
                {
                    lengthLongestWord = word.Length;
                }
            }

            return lengthLongestWord;
        }

        private static void AddEmptyLinesToTable(int padding, int lengthLongestWord, StringBuilder table)
        {
            for (int i = 0; i < padding; i++)
            {
                table.Append("|");
                table.Append($"{ String.Empty.PadRight(lengthLongestWord + 2 * padding, ' ')}");
                table.Append("|");
                table.Append($"{Environment.NewLine}");
            }

        }

        private static void AddTopOrBottomLineToTable(int padding, int lengthLongestWord, StringBuilder table)
        {
            table.Append("+");
            table.Append($"{String.Empty.PadRight(lengthLongestWord + 2 * padding, '-')}");
            table.Append("+");
            table.Append($"{Environment.NewLine}");
        }
    }
}
