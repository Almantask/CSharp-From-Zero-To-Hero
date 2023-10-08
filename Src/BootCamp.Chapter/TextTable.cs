using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
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
        public static void PrintChar(char c, int strLength, StringBuilder sb)
        {
            for (int j = 0; j < (strLength); ++j) {sb.Append(c); }
        }
        public static void PrintHyphen(int strLength, StringBuilder sb)
        {
            sb.Append('+');
            PrintChar('-', strLength, sb);
            sb.Append($"+{Environment.NewLine}");
        }
        public static void PritPipe(int strLength, StringBuilder sb, int padding)
        {
            for (int j = 0; j < padding; ++j)
            {
                sb.Append('|');
                PrintChar(' ', strLength, sb);
                sb.Append($"|{Environment.NewLine}");
            }
        }

        /// <summary>
        /// Build a table for given message with given padding.
        /// Padding means how many spaces will a message be wrapped with.
        /// Table itself is made of: "+-" symbols. 
        /// </summary>
        public static string Build(string message, int padding)
        {
            if(message == null || message.Length == 0)
            {
                return "";
            }
            var sb = new StringBuilder();
            var arr = message.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
            for(int x = 0; x < arr.Length; ++x)
            {
                arr[x] = arr[x].PadLeft(padding + arr[x].Length);
                arr[x] = arr[x].PadRight(padding + arr[x].Length);
            }
            var strLength = 0;
            for (int i = 0; i < arr.Length; ++i)
            {
              if(strLength < arr[i].Length) { strLength = arr[i].Length; }

            }

            PrintHyphen(strLength, sb);
            PritPipe(strLength, sb, padding);

            for (int k = 0; k < arr.Length; ++k)
            {
                sb.Append('|');
                sb.Append(arr[k].PadRight(strLength));
                sb.Append($"|{Environment.NewLine}");
            }

            PritPipe(strLength, sb, padding);
            PrintHyphen(strLength, sb);

            return sb.ToString();
        }
    }
}
