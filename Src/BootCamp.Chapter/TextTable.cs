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
            if (padding < 0) throw new ArgumentOutOfRangeException($"Padding cannot be negative. (value: \"{padding}\")");

            var messageByLine = message.Split(Environment.NewLine);
            var maxLength = FindMaxLength(messageByLine);
            var borderSize = padding * 2 + maxLength;

            // Build message
            var tableMessage = new StringBuilder();
            tableMessage.AppendLine(BuildBorder(borderSize, '+', '-'));
            if (padding > 0) tableMessage.Append(BuildPaddingBorder(borderSize, padding));
            tableMessage.Append(BuildMainMessage(messageByLine, padding, maxLength));
            if (padding > 0) tableMessage.Append(BuildPaddingBorder(borderSize, padding));
            tableMessage.AppendLine(BuildBorder(borderSize, '+', '-'));

            return tableMessage.ToString();
        }

        private static string BuildMainMessage(string[] messageByLine, int padding, int maxLength)
        {
            var message = new StringBuilder();
            foreach (var line in messageByLine)
            {
                var main = $"{line}{new string(' ', maxLength - line.Length)}";
                var outerBorder = new string(' ', padding);
                message.AppendLine($"|{outerBorder}{main}{outerBorder}|");
            }

            return message.ToString();
        }

        private static string BuildBorder(int length, char outer, char inner)
        {
            var border = $"{outer}{new string(inner, length)}{outer}";

            return border;
        }

        private static string BuildPaddingBorder(int borderSize, int padding)
        {
            var border = new StringBuilder();
            for (var i = 0; i < padding; i++)
            {
                border.AppendLine(BuildBorder(borderSize, '|', ' '));
            }

            return border.ToString();
        }

        private static int FindMaxLength(string[] message)
        {
            var maxLength = 0;
            foreach (var line in message)
            {
                if (line.Length > maxLength) maxLength = line.Length;
            }

            return maxLength;
        }
    }
}