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

            if (!(message==null || message.Length == 0))
            {


                int howManyWords = 0;
                int longestWordLength = 0;

                string[] words = message.Split("\r\n");

                StringBuilder sb = new StringBuilder();
                FindLongestWord(message, ref howManyWords, ref longestWordLength);
                int paddingWidth = longestWordLength + 2 * padding;
                sb.Append(BuildFirstOrLast(paddingWidth));

                sb.Append(BuildPadding(paddingWidth, padding));

                for (var i = 0; i < words.Length; i++)
                {
                    //sb.Append($"|");
                    sb.Append("|".PadRight((padding + 1), ' ')).Append(words[i].PadRight(longestWordLength + padding, ' ')).Append("|\r\n");
                }

                sb.Append(BuildPadding(paddingWidth, padding));
                sb.Append(BuildFirstOrLast(paddingWidth));

                //Console.WriteLine(sb.ToString());

                return sb.ToString(); ;
            }
            else
                return "";
        }



        public static void FindLongestWord(string message,ref int howManyWords, ref int longestWordLength)
        {
            longestWordLength = 0;
            string[] words = message.Split("\r\n");
            
             foreach(var word in words)
            {
                if (longestWordLength < word.Length)
                {
                    longestWordLength = word.Length;
                }
            }
            howManyWords = words.Length;
            //return length;
        }

        public static StringBuilder BuildFirstOrLast(int length)
        {
            StringBuilder line = new StringBuilder();
            line.Append('+');
            for (var i=0; i<length;i++)
            {
                line.Append('-');
            }
            line.Append("+\r\n");

            return line;
        }

        public static StringBuilder BuildPadding(int length,int padding)
        {
            StringBuilder sb = new StringBuilder();
            for (var i=0;i<padding;i++)
            {
                sb.Append("|").Append(" ".PadRight(length, ' ')).Append("|\r\n");
            }
            
            return sb;
            
        }
    }
}
