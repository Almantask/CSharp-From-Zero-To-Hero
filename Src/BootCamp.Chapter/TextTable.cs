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
  
            var topAndBottom = BuildTopAndBottom(message, padding);
            var emptyMiddleLines = BuildEmptyMiddleLines(message, padding);

            var sb = new StringBuilder();
            sb.Append(topAndBottom);
            sb.Append(emptyMiddleLines);
            sb.Append(BuildMiddleContainngText(message, padding));
            sb.Append(emptyMiddleLines);
            sb.Append(topAndBottom);

            return sb.ToString();
        }

        public static string BuildMiddleContainngText(string message, int padding)
        {
            var lines = message.Split(Environment.NewLine);
            var middleSb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                middleSb.Append($"|{AddBothSidePaddingTo(lines[i], message, padding)}|{Environment.NewLine}");
            }


            return middleSb.ToString();
        }

        public static string BuildEmptyMiddleLines(string message, int padding)
        {
            if (padding == 0)
            {
                return "";
            }
            var emptyLineSb = new StringBuilder();
            var emptyLine = $"|{AddBothSidePaddingTo("", message, padding)}|{Environment.NewLine}";

            for (int i = 0; i < padding; i++)
            {
                emptyLineSb.Append(emptyLine);
            }
            return emptyLineSb.ToString();
        }

        public static string AddBothSidePaddingTo(string line, string message, int padding)
        {
            var lengthOfLongestLine = LengthOfLongestLine(message);
            var rightPadding = lengthOfLongestLine + padding;
            var leftPadding = lengthOfLongestLine + padding * 2;
            return line.PadRight(rightPadding).PadLeft(leftPadding);
        }


        public static int LengthOfLongestLine(string message)
        {
            var words = message.Split(Environment.NewLine);
            var lengthOfLongestLine = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (lengthOfLongestLine < words[i].Length)
                {
                    lengthOfLongestLine = words[i].Length;
                }
            }

            return lengthOfLongestLine;
        }

        public static string BuildTopAndBottom(string message, int padding)
        {
            var rightPadding = LengthOfLongestLine(message) + padding * 2;
            return $"+{"-".PadRight(rightPadding, '-')}+{Environment.NewLine}";
        }
    }

}