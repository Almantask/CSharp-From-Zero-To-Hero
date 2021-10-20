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
            if (message.Length == 0) return "";

            StringBuilder sb = new StringBuilder();
            StringBuilder horizontalLines = new StringBuilder();
            StringBuilder emptySpacesSB = new StringBuilder();
            StringBuilder paddingSpaceSB = new StringBuilder();
            StringBuilder stringDiffLengthSB = new StringBuilder();

            int[] stringDiffLength = new int[2];
            string trimmedMessage = message.Trim();
            string[] stringSeparators = new string[] { "\r\n", " " };
            string[] textToParse = trimmedMessage.Split(stringSeparators, StringSplitOptions.None);
            //string[] textToParse = trimmedMessage.Split(new char[] {' '});

            var length = 0;
            var emptySpaces = 0;
            var paddingSpaces = padding;
            var shortestTextIndex = 0;

            for (int i = 0; i < stringDiffLength.Length; i++)
            {
                stringDiffLengthSB.Append(" ");
            }

            if (textToParse.Length > 1)
            {
                int[] wordLength = new int[textToParse.Length];
                int longestWord = 0;


                if (textToParse[0].Length < textToParse[1].Length)
                {
                    stringDiffLength[0] = textToParse[1].Length - textToParse[0].Length;
                    shortestTextIndex = 0;
                }
                else
                {
                    stringDiffLength[1] = textToParse[0].Length - textToParse[1].Length;
                    shortestTextIndex = 1;
                }


                for (int i=0; i <textToParse.Length; i++)
                {
                    wordLength[i] = Convert.ToInt16(textToParse[i].Length);
                    if (longestWord < wordLength[i]) longestWord = wordLength[i];

                }
                length = longestWord;
                emptySpaces = longestWord;
            }
            else
            {
                length = message.Length;
                emptySpaces = message.Length;
            }

            for (int i = 0; i < length+paddingSpaces*2; i++)
            {
                horizontalLines.Append("-");
            }

            for (int i = 0; i < emptySpaces; i++)
            {
                emptySpacesSB.Append(" ");
            }

            for (int i = 0; i < paddingSpaces; i++)
            {
                paddingSpaceSB.Append(" ");
            }

            sb.Append($"+{horizontalLines}+{Environment.NewLine}");

            for (int i=0; i<paddingSpaces;i++)
            {
                sb.Append($"|{paddingSpaceSB}{emptySpacesSB}{paddingSpaceSB}|{Environment.NewLine}");
            }

            if (textToParse.Length > 1)
            {
                for (int i = 0; i < textToParse.Length; i++)
                {
                    if (i == shortestTextIndex)
                    {
                        sb.Append($"|{paddingSpaceSB}{textToParse[i]}{stringDiffLengthSB[i]}{paddingSpaceSB}|{Environment.NewLine}");
                    }
                    else
                    {
                        sb.Append($"|{paddingSpaceSB}{textToParse[i]}{paddingSpaceSB}|{Environment.NewLine}");
                    }
                }
            }
            else
            {
                sb.Append($"|{paddingSpaceSB}{textToParse[0]}{paddingSpaceSB}|{Environment.NewLine}");
            }


            for (int i = 0; i < paddingSpaces; i++)
            {
                sb.Append($"|{paddingSpaceSB}{emptySpacesSB}{paddingSpaceSB}|{Environment.NewLine}");
            }

            sb.Append($"+{horizontalLines}+{Environment.NewLine}");

            return sb.ToString();
        }
    }
}
