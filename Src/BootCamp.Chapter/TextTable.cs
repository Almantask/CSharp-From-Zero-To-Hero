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
            if (string.IsNullOrEmpty(message)) return "";

            var textTable = new StringBuilder();
            var maxLength = GetMaxLengthInLine(message) + (padding * 2);
            var messageLines = message.Split(Environment.NewLine);

            var topAndBottomText = String.Concat("+", RepeatWord("-", maxLength), "+", Environment.NewLine);
            var paddingText = String.Concat("|", RepeatWord(" ", maxLength), "|", Environment.NewLine);

            textTable.Append(topAndBottomText);

            for (int i = 0; i < padding; i++)
            {
                textTable.Append(paddingText);
            }

            for (int i = 0; i < messageLines.Length; i++)
            {
                var innerText = String.Concat("|", RepeatWord(" ", padding), messageLines[i], RepeatWord(" ", padding), "|", Environment.NewLine);

                if(innerText.Length < (maxLength + 4))
                {
                    innerText = String.Concat("|", RepeatWord(" ", padding), messageLines[i], RepeatWord(" ", (padding + (maxLength + 4) - innerText.Length)), "|", Environment.NewLine);
                }

                textTable.Append(innerText);
            }

            for (int i = 0; i < padding; i++)
            {
                textTable.Append(paddingText);
            }

            textTable.Append(topAndBottomText);

            return textTable.ToString();
        }

        private static int GetMaxLengthInLine(string message)
        {
            var messageLines = message.Split(Environment.NewLine);
            if (messageLines.Length == 1) return messageLines[0].Length;

            var maxLength = 0;

            for (int i = 0; i < messageLines.Length; i++)
            {
                var lineLength = messageLines[i].Length;
                if (lineLength > maxLength)
                    maxLength = lineLength;
            }

            return maxLength;
        }

        private static string RepeatWord(string word, int count)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(word);
            }
            return sb.ToString();
        }
    }
}
