using System;
using System.Linq;
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
                return "";
            var (stringArray, stringMaxLength) = SplitAndGetMaxLength(message);
            var border = $"{CreateBorder(stringMaxLength + (padding *2))}{Environment.NewLine}";
            var body = $"{BuildBody(stringArray, padding, stringMaxLength)}";

            var table = $"{border}{body}{border}";

            return table;
        }

        private static (string[] stringArray, int stringMaxLenth) SplitAndGetMaxLength(string message)
        {
            if (message.Contains("\r\n"))
            {
                message = message.Replace("\r\n", " ");
            }
            string[] stringArray = message.Split(' ');
            int stringMaxLenth = stringArray.OrderByDescending(s => s.Length).First().Length;

            return (stringArray, stringMaxLenth);
        }

        private static string CreateBorder(int length)
        {
            var border = new StringBuilder();
            border.Append('+').Append('-', length).Append('+');            
            return border.ToString();
        }

        private static StringBuilder BuildBody(string[] message, int padding, int maxLength)
        {
            var text = new StringBuilder();

            var textElements = (padding * 2) + 1;
            var emptySpace = new string(' ', padding);

            for (int i = 1; i <= textElements; i++)
            {
                if (i == (textElements / 2) + 1)
                {
                    text.Append(BuildMessage(message, emptySpace, maxLength));
                }
                else
                {
                    var emptyWord = new string(' ', maxLength);
                    text.AppendLine($"|{emptySpace}{emptyWord}{emptySpace}|");
                }
            }

            return text;
        }

        private static StringBuilder BuildMessage(string[] array, string emptySpace, int longestWord)
        {
            var message = new StringBuilder();
            
            foreach (var words in array)
            {
                string fillEmptySpace = string.Empty;
                if (words.Length != longestWord)
                    fillEmptySpace = new StringBuilder().Append(' ', longestWord - words.Length).ToString();
                
                message.Append($"|{emptySpace}{words}{emptySpace}{fillEmptySpace}|{Environment.NewLine}");
            }

            return message;
        }
    }
}
