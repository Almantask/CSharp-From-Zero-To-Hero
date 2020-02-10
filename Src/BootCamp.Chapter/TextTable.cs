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
        public const string edgeForTopAndBottom = "-";
        public const string corner = "+";
        public const string space = " ";
        public const string sideBorder = "|";

        public static string Build(string message, int padding)
        {

            if (message == "")
            {
                return "";
            }
            int stringLength;
            var messageArray = (message.Contains(Environment.NewLine)) ? message.Split(Environment.NewLine) : null;
            bool isMultiline = !(messageArray == null);

            //find longest message
            stringLength = DetermineMessageWidth(message, messageArray, isMultiline);

            var sb = new StringBuilder();

            ////// Top Border //////
            sb.Append(PrintTopOrBottomBorder(padding, stringLength));

            ////// Top Vertical Padding //////
            for (int i = 0; i < padding; i++)
            {
                sb.Append(PrintVerticalPaddingRow(padding, stringLength));
            }

            ////// Message //////
            if (isMultiline)
            {
                for (int i = 0; i < messageArray.Length; i++)
                {
                    sb.Append(PrintMessageInTable(messageArray[i], padding));
                }
            }
            else
            {
                sb.Append(PrintMessageInTable(message, padding));
            }

            ////// Bottom Vertical Padding //////
            for (int i = 0; i < padding; i++)
            {
                sb.Append(PrintVerticalPaddingRow(padding, stringLength));
            }

            ////// Bottom Border //////
            sb.Append(PrintTopOrBottomBorder(padding, stringLength));

            return sb.ToString();
        }

        private static int DetermineMessageWidth(string message, string[] messageArray, bool isMultiline)
        {
            int stringLength;
            if (isMultiline)
            {
                stringLength = messageArray[0].Length > messageArray[1].Length ? messageArray[0].Length : messageArray[1].Length;
                for (int i = 0; i < messageArray.Length; i++)
                {
                    messageArray[i] = messageArray[i].Length < stringLength ? messageArray[i].PadRight(stringLength) : messageArray[i];
                }
            }
            else
            {
                stringLength = message.Length;
            }

            return stringLength;
        }

        public static string PrintVerticalPaddingRow(int padding, int stringLength)
        {
            var sb = new StringBuilder();
            sb.Append(sideBorder);
            for (int i = 0; i < padding * 2 + stringLength; i++)
            {
                sb.Append(space);
            }
            sb.Append(sideBorder);
            sb.Append($"{Environment.NewLine}");
            return sb.ToString();
        }
        public static string PrintMessageInTable(string message, int padding)
        {
            var sb = new StringBuilder();
            sb.Append(sideBorder);
            for (int i = 0; i < padding; i++)
            {
                sb.Append(space);
            }
            sb.Append(message.PadLeft(padding));
            for (int i = 0; i < padding; i++)
            {
                sb.Append(space);
            }
            sb.Append(sideBorder);
            sb.Append($"{Environment.NewLine}");

            return sb.ToString(); 
        }
        public static string PrintTopOrBottomBorder(int padding, int stringLength)
        {
            var sb = new StringBuilder();
            sb.Append(corner);
            for (int i = 0; i < padding * 2 + stringLength; i++)
            {
                sb.Append(edgeForTopAndBottom);
            }
            sb.Append(corner);
            sb.Append($"{Environment.NewLine}");

            return sb.ToString();
        }
    }
}