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

            var (messageArray, maxWordLength) = SplitLinesAndPadding(message);
            var border = $"{BuildBorder(maxWordLength + (padding * 2))}{Environment.NewLine}";
            var body = BuildBody(messageArray, padding, maxWordLength);

            return $"{border}{body}{border}";
        }

        private static (string[] messageArray, int maxLength) SplitLinesAndPadding(string message)
        {
            var arr = message.Split(System.Environment.NewLine);
            var maxLength = 0;

            foreach (var words in arr)
            {
                if (words.Length > maxLength) maxLength = words.Length;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var spacesToAdd = new string(' ', maxLength - arr[i].Length);
                arr[i] += spacesToAdd;
            }

            return (arr, maxLength);
        }

        private static StringBuilder BuildBody(string[] message, int padding, int maxLength)
        {
            var text = new StringBuilder();

            var middleElements = (padding * 2) + 1;
            var emptySpace = new string(' ', padding);

            for (int i = 1; i <= middleElements; i++)
            {
                if (i == (middleElements / 2) + 1)
                {
                    text.Append(BuildMessage(message, emptySpace));
                }
                else
                {
                    var emptyWord = new string(' ', maxLength);
                    text.Append($"|{emptySpace}{emptyWord}{emptySpace}|{Environment.NewLine}");
                }
            }

            return text;
        }

        private static StringBuilder BuildMessage(string[] array, string emptySpace)
        {
            var temp = new StringBuilder();
            foreach (var words in array)
            {
                temp.Append($"|{emptySpace}{words}{emptySpace}|{Environment.NewLine}");
            }

            return temp;
        }

        private static string BuildBorder(int length)
        {
            var text = new string('-', length);

            return $"+{text}+";
        }
    }
}
