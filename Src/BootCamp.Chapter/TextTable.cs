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

            var length = message.Length;
            var emptySpaces = message.Length;
            var paddingSpaces = padding;


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

            sb.Append($"|{paddingSpaceSB}{message}{paddingSpaceSB}|{Environment.NewLine}");

            for (int i = 0; i < paddingSpaces; i++)
            {
                sb.Append($"|{paddingSpaceSB}{emptySpacesSB}{paddingSpaceSB}|{Environment.NewLine}");
            }

            sb.Append($"+{horizontalLines}+{Environment.NewLine}");

            return sb.ToString();
        }
    }
}
