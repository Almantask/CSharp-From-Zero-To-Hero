using System;
using System.Collections.Generic;
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
            if (string.IsNullOrEmpty(message) && padding == 0)
            {
                return "";
            }

            var longestWordInMessageSize = LongestWordInMessageSize(message);

            var newHorizontalBorder = new StringBuilder();
            newHorizontalBorder.Append(cornerChar).Append(horizontalWallChar, longestWordInMessageSize + (padding * 2)).Append(cornerChar).Append(Environment.NewLine);

            var newEmptyLine = new StringBuilder();
            newEmptyLine.Append(verticalWallChar).Append(' ', longestWordInMessageSize + (padding * 2)).Append(verticalWallChar).Append(Environment.NewLine);

            var sb = new StringBuilder();

            sb.Append(newHorizontalBorder);
            for (var i = 0; i < padding; i++)
            {
                sb.Append(newEmptyLine);
            }

            foreach (var word in message.Split(dividerChar))
            {
                sb.Append(verticalWallChar);
                sb.Append(' ', padding);
                sb.Append(word);
                sb.Append(' ', longestWordInMessageSize - word.Length);
                sb.Append(' ', padding);
                sb.Append(verticalWallChar);
                sb.Append(Environment.NewLine);
            }
            for (var i = 0; i < padding; i++)
            {
                sb.Append(newEmptyLine);
            }

            sb.Append(newHorizontalBorder);

            return sb.ToString();
        }

        private const string dividerChar = "\r\n";
        private const char cornerChar = '+';
        private const char horizontalWallChar = '-';
        private const char verticalWallChar = '|';

        private static int LongestWordInMessageSize(string message)
        {
            int size = 0;
            foreach (var word in message.Split(dividerChar))
            {
                if (word.Length > size)
                {
                    size = word.Length;
                }
            }
            return size;
        }
    }
}