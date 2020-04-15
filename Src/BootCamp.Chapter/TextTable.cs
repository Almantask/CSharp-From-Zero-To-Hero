using System;

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
            if (message == "") return "";

            var (fixedSpaces, maxLenght) = SplitAndFixSpace(message);
            var border = $"{Border(maxLenght + (padding * 2))}{Environment.NewLine}";

            var newText = $"{border}" +
                          $"{Middle(fixedSpaces, padding, maxLenght)}" +
                          $"{border}";

            return newText;
        }

        private static (string[] fixedSpaces, int maxLenght) SplitAndFixSpace(string message)
        {

            var arr = message.Split(System.Environment.NewLine);
            int maxLenght = 0;

            foreach (var words in arr)
            {
                if (words.Length > maxLenght) maxLenght = words.Length;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var spacesToAdd = new string(' ', maxLenght - arr[i].Length);
                arr[i] += spacesToAdd;
            }

            return (arr, maxLenght);
        }

        private static string Middle(string[] message, int padding, int maxLenght)
        {
            // Main text to return
            var text = new System.Text.StringBuilder();

            int middleElements = (padding * 2) + 1;
            var emptySpace = new string(' ', padding);

            for (int i = 1; i <= middleElements; i++)
            {
                if (i == (middleElements / 2) + 1)
                {
                    text.Append(MiddleText(message, emptySpace));
                }
                else
                {
                    var placebo = new string(' ', maxLenght);
                    text.Append($"|{emptySpace}{placebo}{emptySpace}|{Environment.NewLine}");
                }
            }

            return text.ToString();
        }

        private static string MiddleText(string[] array, string emptySpace)
        {
            var temp = new System.Text.StringBuilder();
            foreach (var words in array)
            {
                temp.Append($"|{emptySpace}{words}{emptySpace}|{Environment.NewLine}");
            }

            return temp.ToString();
        }

        private static string Border(int lenght)
        {
            var text = new string('-', lenght);

            return $"+{text}+";
        }
    }
}
