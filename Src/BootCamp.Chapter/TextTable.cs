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
            var sb = new StringBuilder();

            sb.Append(AddBorder(message, padding));
            sb.Append(AddPaddingLines(message, padding));
            sb.Append(AddMessageLines(message, padding));
            sb.Append(AddPaddingLines(message, padding));
            sb.Append(AddBorder(message, padding));

            return sb.ToString();
        }

        private static string AddBorder(string message, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(message);
            int borderLength = maxContentLength + padding * 2;
            string border = $"+{"-".PadRight(borderLength, '-')}+{Environment.NewLine}";
            return border;
        }

        private static string AddPaddingLines(string message, int padding)
        {
            int maxContentLength = LengthOfTheLongestLine(message);
            int lineLength = maxContentLength + padding * 2;
            if (padding == 0) return "";

            string line = $"|{" ".PadRight(lineLength, ' ')}|{Environment.NewLine}";
            return line;
        }

        private static string AddMessageLines(string message, int padding)
        {
            string[] messageLines = message.Split("{Environment.NewLine}");
            int maxContentLength = LengthOfTheLongestLine(message);

            var allMessageLines = new StringBuilder();
            for (int i = 0; i <= messageLines.Length -1; i++)
            {
                string margin = "".PadRight(padding);
                string content = messageLines[i].PadRight(maxContentLength);
                allMessageLines.Append($"|{margin}{content}{margin}|{Environment.NewLine}");
            }
            return allMessageLines.ToString();
        }

        private static int LengthOfTheLongestLine(string message)
        {
            int longestLine = 0;
            string[] messageLines = message.Split("{Environment.NewLine}");
            foreach (string line in messageLines)
            {
                if (line.Length > longestLine) longestLine = line.Length;
            }

            return longestLine;
        }
    }
}
