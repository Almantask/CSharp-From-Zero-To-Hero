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

            int maxLength = MaxLength(stringArray);

            // get the borders and vertical padding
            const char corner = '+';
            int width = maxLength + padding * 2;
            string horizontalPadding = GethorizontalPadding(padding);
            string leftBorder = "|" + horizontalPadding;
            string rightBorder = horizontalPadding + "|";
            StringBuilder verticalPadding = new StringBuilder();
            SetVerticalPadding(verticalPadding, leftBorder, rightBorder, maxLength, padding);

            StringBuilder textTable = new StringBuilder();

            // top border
            string HorizontalBorder = GetHorizontalBorder(corner, width);
            textTable.Append(HorizontalBorder);
            textTable.Append(verticalPadding);

            //rows
            SetRows(textTable, stringArray, maxLength, leftBorder, rightBorder);

            // bottom
            textTable.Append(verticalPadding);
            textTable.Append(HorizontalBorder);

            return textTable.ToString();
        }

        static int MaxLength(string[] array)
        {
            int maxLength = -1;

            foreach (string item in array)
            {
                if (maxLength < item.Length)
                {
                    maxLength = item.Length;
                }
            }
            return maxLength;
        }

        static string FillString(char c, int length) => new string(c, length);
        static string GethorizontalPadding(int padding) => padding > 0 ? FillString(' ', padding) : "";

        static string GetHorizontalBorder(char corner, int length)
        {
            return $"{corner}{FillString('-', length)}{corner}{Environment.NewLine}";
        }

        static void SetVerticalPadding(StringBuilder sb, string leftBorder, string rightBorder, int length, int padding)
        {
            if (padding > 0)
            {
                for (int i = 0; i < padding; i++)
                {
                    sb.Append($"{leftBorder}{FillString(' ', length)}{rightBorder}{Environment.NewLine}");
                }
            }
        }

        static void SetRows(StringBuilder sb, string[] array, int padding, string leftBorder, string rightBorder) 
        {
            foreach (string item in array)
            {
                string sentence = item.PadRight(padding);
                sb.Append($"{leftBorder}{sentence}{rightBorder}{Environment.NewLine}");
            }
        }

    }
}
