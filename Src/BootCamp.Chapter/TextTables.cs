using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class TextTables
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
            if (String.IsNullOrEmpty(message)) return "";

            var sb = new StringBuilder();

            string[] messageLines = message.Split(Environment.NewLine);

            sb.Append(AddBorder(messageLines, padding));
            sb.Append(AddPaddingLines(messageLines, padding));
            sb.Append(AddMessageLines(messageLines, padding));
            sb.Append(AddPaddingLines(messageLines, padding));
            sb.Append(AddBorder(messageLines, padding));

            return sb.ToString();
        }

        private static string AddBorder(string[] messageLines, int padding)
        {
            int lineLength = LineLength(messageLines, padding);
            string border = CreateLine('+', '-', lineLength);
            return border;
        }

        private static string AddPaddingLines(string[] messageLines, int padding)
        {
            int lineLength = LineLength(messageLines, padding);
            if (padding == 0) return "";

            var line = new StringBuilder();
            for (int i = 0; i < padding; i++)
            {
                line.Append(CreateLine('|', ' ', lineLength));

            }
            return line.ToString();
        }

        private static string AddMessageLines(string[] messageLines, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(messageLines);

            var allMessageLines = new StringBuilder();
            for (int i = 0; i <= messageLines.Length - 1; i++)
            {
                string margin = "".PadRight(padding);
                string content = messageLines[i].PadRight(maxContentLength);
                allMessageLines.Append($"|{margin}{content}{margin}|{Environment.NewLine}");
            }
            return allMessageLines.ToString();
        }

        private static int LengthOfTheLongestLine(string[] messageLines)
        {
            int longestLine = 0;
            foreach (string line in messageLines)
            {
                if (line.Length > longestLine) longestLine = line.Length;
            }

            return longestLine;
        }

        private static string CreateLine(char border, char inside, int lineLength)
        {
            return $"{border}{"".PadRight(lineLength, inside)}{border}{Environment.NewLine}";
        }

        private static int LineLength(string[] messageLines, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(messageLines);
            return maxContentLength + padding * 2;
        }
    }
}
