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
            Console.WriteLine(sb.Append($"+-----+{Environment.NewLine}|{ message}|{Environment.NewLine}+-----+"));
            //Console.WriteLine(sb.Append($"|{message}|"));
            //Console.WriteLine($"+-----+");
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
            //Console.WriteLine(sb.Append($"+-----+{Environment.NewLine}|{message}|{Environment.NewLine}+-----+"));
            Console.WriteLine($"|{message}|");
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
            return "";
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
