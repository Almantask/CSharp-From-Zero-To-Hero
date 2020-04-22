using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class TextTable
    {
        const string cornerPiece = "+";
        const string horizontalBorder = "-";
        const string verticalBorder = "|";

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols.
        /// </summary>
        public static string Build(string message, int padding)
        {
            if (string.IsNullOrWhiteSpace(message))
            {
                return "";
            }

            var words = message.Split(Environment.NewLine);

            int maxLength = GetMaxLength(words);
            int messageWidth = maxLength + 2 * padding;

            StringBuilder sbTable = new StringBuilder();

            AppendHorizontalBorder(sbTable, messageWidth);
            AppendEmptyLines(sbTable, maxLength, padding);
            AppendLine(words, sbTable, maxLength, padding);
            AppendEmptyLines(sbTable, maxLength, padding);
            AppendHorizontalBorder(sbTable, messageWidth);

            return sbTable.ToString();
        }

        private static void AppendLine(string[] inputArray, StringBuilder sbTable, int maxLength, int padding)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                sbTable.Append(verticalBorder).Append(String.Empty.PadRight(padding));
                sbTable.Append($"{inputArray[i].PadRight(maxLength)}");
                sbTable.Append(String.Empty.PadRight(padding)).Append(verticalBorder);
                sbTable.Append(Environment.NewLine);
            }
        }

        private static void AppendEmptyLines(StringBuilder sbTable, int maxLength, int padding)
        {
            for (int j = 0; j < padding; j++)
            {
                sbTable.Append(verticalBorder);
                sbTable.Append(String.Empty.PadRight(maxLength + 2 * padding));
                sbTable.Append(verticalBorder);
                sbTable.Append(Environment.NewLine);
            }
        }

        private static void AppendHorizontalBorder(StringBuilder sbTable, int width)
        {
            sbTable.Append(cornerPiece);
            for (int i = 1; i <= width; i++)
            {
                sbTable.Append(horizontalBorder);
            }
            sbTable.Append(cornerPiece);
            sbTable.Append(Environment.NewLine);
        }

        private static int GetMaxLength(string[] inputArray)
        {
            int currentMax = -1;

            foreach (var item in inputArray)
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