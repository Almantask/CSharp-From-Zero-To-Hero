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
        private static string _corner = "+";
        private static string _horizontalBorder = "-";
        private static string _verticalBorder = "|";

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

            var wordArray = message.Split(Environment.NewLine);

            int maxLength = MaxLength(wordArray);
            int messageWidth =  maxLength + 2 * padding;

            StringBuilder textTable = new StringBuilder();

            AddHorizontalLine(textTable, messageWidth);
            AddEmptyLines(textTable, maxLength, padding);
            AddLinesWithWords(wordArray, textTable, maxLength, padding);
            AddEmptyLines(textTable, maxLength, padding);
            AddHorizontalLine(textTable, messageWidth);

            return textTable.ToString();
        }

        private static void AddLinesWithWords(string[] wordArray, StringBuilder textTable, int maxLength, int padding)
        {
            for (int i = 0; i < wordArray.Length; i++)
            {
                textTable.Append(_verticalBorder).Append(String.Empty.PadRight(padding));

                textTable.Append($"{wordArray[i].PadRight(maxLength)}");

                textTable.Append(String.Empty.PadRight(padding)).Append(_verticalBorder);

                textTable.Append(Environment.NewLine);
            }
        }

        private static void AddEmptyLines(StringBuilder textTable, int maxLength, int padding)
        {
            for (int j = 0; j < padding; j++)
            {
                textTable.Append(_verticalBorder);
                textTable.Append(String.Empty.PadRight(maxLength + 2 * padding));
                textTable.Append(_verticalBorder);
                textTable.Append(Environment.NewLine);
            }
        }

        private static void AddHorizontalLine(StringBuilder textTable, int width)
        {
            textTable.Append(_corner);
            for (int i = 1; i <= width; i++)
            {
                textTable.Append(_horizontalBorder);
            }
            textTable.Append(_corner);
            textTable.Append(Environment.NewLine);
        }

        private static int MaxLength(string[] wordArray)
        {
            int currentMax = -1;

            foreach (var item in wordArray)
            {
                if (item.Length > currentMax)
                {
                    currentMax = item.Length;
                }
            }
            return currentMax;
        }
    }
}
