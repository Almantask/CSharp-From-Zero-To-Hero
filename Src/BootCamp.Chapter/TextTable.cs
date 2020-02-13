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
        */

        public static string Build(string message, int padding)
        {
            var sb = new StringBuilder();
            sb.Append($"+-----+{Environment.NewLine}|{ message}|{Environment.NewLine}+-----+");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        /*
         Input: $"Hello{Environment.NewLine}World!", 0
           +------+
           |Hello |
           |World!|
           +------+
         */

        public static string Build1(string message, int padding)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"+------+");
            sb.AppendLine($"|{message.Substring(0, 5).PadRight(6)}|");
            sb.AppendLine($"|{message.Substring(6, 7).Trim()}|");
            sb.AppendLine($"+------+");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }


        /*
         Input: "Hello", 1
           +-------+
           |       |
           | Hello |
           |       |
           +-------+
         */

        public static string Build2(string message, int padding)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"+-------+");
            sb.AppendLine($"|       |");
            sb.AppendLine($"| {message.Substring(0, 5).PadRight(6)}|");
            sb.AppendLine($"|       |");
            sb.AppendLine($"+-------+");
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        //public static string Build(string message, int padding)
        //{
        //    return "";
        //}
    }
}