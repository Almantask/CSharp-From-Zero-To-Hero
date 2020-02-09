using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public static class TextTable
    {
        private const char cornerChar = '+';
        private const char horizontalBorderChar = '-';
        private const char horizontalPaddingChar = ' ';
        private const char verticalBorderChar = '|';
        private static readonly string divider = Environment.NewLine;
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

            // store size in a variable so we don't call the same method so many times
            var longestWordInMessageSize = LongestWordInMessageSize(message);

            var sb = new StringBuilder();

            // create a padded line
            var emptyLine = new StringBuilder();
            emptyLine.Append(verticalBorderChar)
                .Append(horizontalPaddingChar, longestWordInMessageSize + (padding * 2))
                .Append(verticalBorderChar)
                .Append(Environment.NewLine);

            // create horizontal border
            var horizontalBorder = new StringBuilder();
            horizontalBorder.Append(cornerChar)
                .Append(horizontalBorderChar, longestWordInMessageSize + (padding * 2))
                .Append(cornerChar)
                .Append(Environment.NewLine);

            // append top horizontal border
            sb.Append(horizontalBorder);

            // append padded line
            for (var i = 0; i < padding; i++)
            {
                sb.Append(emptyLine);
            }

            var wordsInMessage = message.Split(divider);

            // creating and printing text message
            foreach (var word in wordsInMessage)
            {
                sb.Append(verticalBorderChar); 
                sb.Append(horizontalPaddingChar, padding);
                sb.Append(word);
                sb.Append(horizontalPaddingChar, longestWordInMessageSize - word.Length);
                sb.Append(horizontalPaddingChar, padding);
                sb.Append(verticalBorderChar);
                sb.Append(Environment.NewLine);
            }

            // printing padded line
            for (var i = 0; i < padding; i++)
            {
                sb.Append(emptyLine);
            }
            // printing bottom horizontal border
            sb.Append(horizontalBorder);

            return sb.ToString();
        }

        ///<summary>
        ///Helper method for finding longest word in message.
        ///This helps printing appropriate size text, border and padded lines.
        ///</summary>
        private static int LongestWordInMessageSize(string message)
        {
            int size = 0;
            foreach (var word in message.Split(divider))
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