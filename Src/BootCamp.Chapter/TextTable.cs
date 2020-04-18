using System;
using System.Collections.Generic;
using System.Linq;

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

            var main = InitializeMain(message, out var maxLength);
            BuildMainLines(padding, main, maxLength);
            var paddingLines = BuildPaddingLines(padding, maxLength);
            var border = $"+{GenSpaces((padding * 2 + maxLength), '-')}+";

            return $"{BuildFinalMessage(border, paddingLines, main)}{Environment.NewLine}";
        }

        private static List<string> InitializeMain(string message, out int maxLength)
        {
            var main = new List<string>();
            maxLength = 0;
            foreach (var line in message.Split($"{Environment.NewLine}"))
            {
                if (line.Length > maxLength) maxLength = line.Length;
                main.Add(line);
            }

            return main;
        }

        private static void BuildMainLines(int padding, List<string> main, int maxLength)
        {
            for (var i = 0; i <= main.Count - 1; i++)
            {
                var length = maxLength - main[i].Length;
                var temp = main[i] + GenSpaces(length);

                main[i] = $"|{GenSpaces(padding)}{temp}{GenSpaces(padding)}|";
            }
        }

        private static List<string> BuildPaddingLines(int padding, int maxLength)
        {
            var paddingLines = new List<string>();
            for (var i = 1; i <= padding; i++)
            {
                paddingLines.Add($"|{GenSpaces(padding)}{GenSpaces(maxLength)}{GenSpaces(padding)}|");
            }

            return paddingLines;
        }

        private static string BuildFinalMessage(string border, List<string> paddingLines, List<string> main)
        {
            var totalMessage = new List<string>();
            totalMessage.Add(border);
            totalMessage.AddRange(paddingLines);
            totalMessage.AddRange(main);
            totalMessage.AddRange(paddingLines);
            totalMessage.Add(border);

            return string.Join(Environment.NewLine, totalMessage);
        }

        private static string GenSpaces(int length, char symbol = ' ')
        {
            return new string(symbol, length);
        }
    }
}
