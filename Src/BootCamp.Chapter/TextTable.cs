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
            var whiteSpace = "";
            var length = message.Length + padding*2;
            sb.Append($"+{whiteSpace.PadRight(length, '-')}+");
            BuildWhitespace(sb, whiteSpace, padding, length);
            var messageWithPad = $"|{whiteSpace.PadRight(padding, ' ')} {message} {whiteSpace.PadRight(padding, ' ')}|";
            sb.Append($"{messageWithPad}{Environment.NewLine}");
            BuildWhitespace(sb, whiteSpace, padding, length);
            sb.Append($"+{whiteSpace.PadRight(length, '-')}+");

            return sb.ToString();
        }

        public static void BuildWhitespace(StringBuilder sb, string whiteSpace, int padding, int length)
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
}
