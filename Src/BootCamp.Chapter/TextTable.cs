using System;
using System.Net.NetworkInformation;
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
            if (!string.IsNullOrEmpty(message))
            {
                var sb = new StringBuilder();
                var messages = message.Split(Environment.NewLine);
                var longestString = "";
                for (int i = 0; i < messages.Length; i++)
                {
                    if (messages[i].Length > longestString.Length)
                        longestString = messages[i];
                }
                var whiteSpace = "";
                var length = longestString.Length + padding * 2;
                sb.Append($"+{whiteSpace.PadRight(length, '-')}+{Environment.NewLine}");
                BuildWhitespace(sb, whiteSpace, padding, length);
                BuildMessage(sb, messages, padding, longestString.Length);
                BuildWhitespace(sb, whiteSpace, padding, length);
                sb.Append($"+{whiteSpace.PadRight(length, '-')}+{Environment.NewLine}");

                return sb.ToString();
            }
            return "";
        }

        public static void BuildWhitespace(StringBuilder sb, string whiteSpace, int padding, int length)
        {
            if (padding > 0)
            {
                for (int i = 0; i < padding; i++)
                {
                    sb.Append("|");
                    sb.Append(whiteSpace.PadRight(length, ' '));
                    sb.Append("|");
                    sb.Append(Environment.NewLine);
                }
            }
        }

        public static void BuildMessage(StringBuilder sb, string[] messages, int padding, int length)
        {
            var whiteSpace = "";
            for (int i = 0; i < messages.Length; i++)
            {
                var message = messages[i];
                sb.Append($"|{whiteSpace.PadRight(padding, ' ')}{message.PadRight(message.Length+(length-message.Length), ' ')}{whiteSpace.PadRight(padding, ' ')}|{Environment.NewLine}");
            }
        }
    }
}
