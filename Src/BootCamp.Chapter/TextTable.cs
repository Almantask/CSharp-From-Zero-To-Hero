using System;
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
            Bottom(totalLength);
            WriteLine();
            // upper part
            Padding(padding, totalLength);
            // middle output
            if(isMultiLineInput)
            {
                newMessage = message.Split(Environment.NewLine); 
                for(int i =0; i < newMessage.Length; i++)
                {
                    string newPaddingLeft = newMessage[i].PadLeft(newMessage[i].Length + padding);
                    string newPaddingRight = newPaddingLeft.PadRight(totalLength);
                    Write("|" + newPaddingRight);
                    WriteLine("|");
                }
            }
            else
            {
                string paddingLeft = message.PadLeft(totalLength - padding);
                string paddingRight = paddingLeft.PadRight(totalLength);
                Write("|" + paddingRight);
                WriteLine("|");
            }
            //lower part
            Padding(padding, totalLength);
            //bottom line
            Bottom(totalLength);

            return "0";
        }
        public static void Bottom(int length)
        {
            Write("+");
            for (int i = 0; i < length; i++)
            {
                Write("-");
            }
            Write("+");
        }
        public static void Padding(int padding,int length)
        {
            for (int i = 0; i < padding; i++)
            {
                Write("|");
                for (int j = 0; j < length; j++)
                {
                    Write(" ");
                }
                WriteLine("|");
            }
        }
    }
}
