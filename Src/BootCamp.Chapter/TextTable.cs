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
            if (message.Length == 0 || message == null) return "";

            var textTable = new StringBuilder();
            string[] seperatedMessage = message.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

            // Find the max length of the longest word in the message
            int maxCharacters = 0;
            foreach (var word in seperatedMessage)
            {
                if (word.Length > maxCharacters)
                {
                    maxCharacters = word.Length;
                }
            }

            // Make-up of number of characters
            int maxWidth = maxCharacters + (padding * 2);
            string minus = new string('-', maxWidth);
            string emptyLine = new string(' ', maxWidth);
            string emptySpace = new string(' ', padding);

            // TopLine
            textTable.Append($"+{minus}+\r\n");

            // NewLine if padding
            for (int i = 0; i < padding; i++)
            {
                textTable.Append($"|{emptyLine}|\r\n");
            }

            // Message line(s)
            for (int j = 0; j < seperatedMessage.Length; j++)
            {
                string leftOver = new string(' ', maxWidth - seperatedMessage[j].Length - (padding*2));
                textTable.Append($"|{emptySpace}{seperatedMessage[j]}{emptySpace}{leftOver}|\r\n");
            }

            // NewLine if padding
            for (int i = 0; i < padding; i++)
            {
                textTable.Append($"|{emptyLine}|\r\n");
            }

            // BottomLine
            textTable.Append($"+{minus}+\r\n");


            return Convert.ToString(textTable);
        }
    }
}
