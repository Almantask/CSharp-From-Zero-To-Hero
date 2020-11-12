using System;
using System.Text;
using static System.Console;

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
            if(message == string.Empty)
            {
                return string.Empty;
            }

            int totalLength = 0;
            bool isMultiLineInput = message.Contains(Environment.NewLine);
            string[] newMessage;
            if(isMultiLineInput)
            {
                newMessage = message.Split(Environment.NewLine);
                for(int i = 0; i < newMessage.Length; i++)
                {
                    if (totalLength < newMessage[i].Length)
                        totalLength = newMessage[i].Length;                   
                }
                totalLength += padding * 2;
            }
            else
            {
                char[] input = message.ToCharArray();
                totalLength = input.Length + padding * 2;
            }

            //first line in output
            string top = Bottom(totalLength);
            WriteLine();
            // upper part
            string upper = Padding(padding, totalLength);
            // middle output
            string middle = null;
            if(isMultiLineInput)
            {
                newMessage = message.Split(Environment.NewLine); 
                for(int i =0; i < newMessage.Length; i++)
                {
                    string newPaddingLeft = newMessage[i].PadLeft(newMessage[i].Length + padding);
                    string newPaddingRight = newPaddingLeft.PadRight(totalLength);
                    middle += "|" + newPaddingRight + "|";
                    middle += $"{ Environment.NewLine}";
                }
            }
            else
            {
                string paddingLeft = message.PadLeft(totalLength - padding);
                string paddingRight = paddingLeft.PadRight(totalLength);
                middle += "|" + paddingRight + "|";
                middle += $"{Environment.NewLine}";
            }
            //lower part
            string lower = Padding(padding, totalLength);
            //bottom line
            string bottom = Bottom(totalLength);

            if (padding > 0)
                return top + upper + middle + lower + bottom;
            else
                return top + middle + bottom;

        }
        public static string Bottom(int length)
        {
            StringBuilder sb = new StringBuilder();  
            sb.Append("+");
            for (int i = 0; i < length; i++)
            {
               sb.Append("-");
            }
            sb.Append("+");
            return $"{sb}{Environment.NewLine}";
        }
        public static string Padding(int padding,int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < padding; i++)
            {
                sb.Append("|");
                for (int j = 0; j < length; j++)
                {
                    sb.Append(" ");
                }
                sb.Append("|");
            }
            return $"{sb}{Environment.NewLine}";
        }
    }
}
