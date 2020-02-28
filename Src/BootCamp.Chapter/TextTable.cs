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

            // split the message
            string[] stringArray = message.Split(Environment.NewLine);
            int maxLength = -1;


            // calculate max length
            foreach (string item in stringArray)
            {
                if (maxLength < item.Length)
                {
                    maxLength = item.Length;
                }
            }

            // calculate table borders
            const char corner = '+';
            int width = maxLength + padding * 2;
            string topLine = new string('-', width);
            string bottomLine = topLine;
            string horizontalPadding = padding > 0 ? new string(' ', padding) : "";
            string leftBorder = "|" + horizontalPadding;
            string rightBorder = horizontalPadding + "|";
            StringBuilder verticalPadding = new StringBuilder();
            string newLine = Environment.NewLine;

            if (padding > 0)
            {
                for (int i = 0; i < padding; i++)
                {
                    verticalPadding.Append(leftBorder + new string(' ', maxLength) + rightBorder + newLine);
                }
            }

            // top border
            StringBuilder result = new StringBuilder($"{corner}{topLine}{corner}{newLine}");
            result.Append(verticalPadding);

            //rows
            foreach (string item in stringArray)
            {
                string sentence = item.PadRight(maxLength);
                result.Append($"{leftBorder}{sentence}{rightBorder}{newLine}");
            }

            // bottom
            result.Append(verticalPadding);
            result.Append($"{corner}{bottomLine}{corner}{newLine}");

            return result.ToString();
        }

        
    }
}
