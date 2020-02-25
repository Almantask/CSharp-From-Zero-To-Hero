using System;
using System.Text;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public class TextTable
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
        /// Table itself is made of: "+-" symbolmessage. 
        /// </summary>
        public string Build(string message, int padding)
        {
            //Analyze message
            if (String.IsNullOrEmpty(message))
            {
                return "";
            }
            var numOfMessageLines = GetNumberOfMessageLines(message);
            var messageLine = GetMessageLines(message, numOfMessageLines);
            var maxLength = GetMaxMessageLineLength(messageLine);

            //Build table from message
            return BuildTable(messageLine, maxLength, padding);
        }

        private static int GetNumberOfMessageLines(string message)
        {
            var numOfLines = 1;

            for (var i = 0; i < message.Length - 1; i++)
            {
                if (message[i] == '\r' && message[i + 1] == '\n')
                {
                    numOfLines++;
                }
            }

            return numOfLines;
        }

        private static string[] GetMessageLines(string message, int numOfMessageLines)
        {
            var messageLine = new string[numOfMessageLines];
            var messageCount = 0;
            var beginPos = 0;
            var endPos = 0;

            if (numOfMessageLines == 0 && message.Length > 0)
            {
                messageLine[0] = message;
            }

            for (var i = 0; i < message.Length - 1; i++)
            {
                if (message[i] == '\r' && message[i + 1] == '\n')
                {
                    endPos = i - 1;
                    messageLine[messageCount++] = message.Substring(beginPos, endPos - beginPos + 1);
                    beginPos = i + 2;
                }
            }

            if (endPos <= message.Length)
            {
                messageLine[messageCount] = message.Substring(beginPos, message.Length - beginPos);
            }

            return messageLine;
        }

        private static int GetMaxMessageLineLength(string[] messageLine)
        {
            var maxLength = 0;

            for (var i = 0; i < messageLine.Length; i++)
            {
                if (maxLength < messageLine[i].Length)
                {
                    maxLength = messageLine[i].Length;
                }
            }

            return maxLength;
        }

        private static string BuildTable(string[] messageLine, int maxLength, int padding)
        {
            var tableLine = BuildBorderLine(maxLength, padding, "+", "-");
            var table = new StringBuilder(tableLine + Environment.NewLine);

            for (var i = 0; i < padding; i++)
            {
                tableLine = BuildBorderLine(maxLength, padding, "|", " ");
                table.Append(tableLine + Environment.NewLine);
            }

            for (var i = 0; i < messageLine.Length; i++)
            {
                tableLine = BuildMessageLine(maxLength, padding, "|", messageLine[i]);              
                table.Append(tableLine + Environment.NewLine);
            }

            for (var i = 0; i < padding; i++)
            {
                tableLine = BuildBorderLine(maxLength, padding, "|", " ");
                table.Append(tableLine + Environment.NewLine);
            }

            tableLine = BuildBorderLine(maxLength, padding, "+", "-");
            table.Append(tableLine + Environment.NewLine);

            return table.ToString();
        }

        private static string BuildBorderLine(int maxLength, int padding, string sideBorder, string edgeBorder)
        {
            var line = new StringBuilder(sideBorder);
            for (var i = 0; i < maxLength + 2 * padding; i++)
            {
                line.Append(edgeBorder);
            }
            line.Append(sideBorder);

            return line.ToString();
        }

        private static string BuildMessageLine(int maxLength, int padding, string sideBorder, string messageLine)
        {
            var line = new StringBuilder(sideBorder);
            for (var i = 0; i < (maxLength - messageLine.Length) / 2 + padding; i++)
            {
                line.Append(" ");
            }

            line.Append(messageLine);

            for (var i = 0; i < (maxLength - messageLine.Length) / 2 + padding + ((maxLength - messageLine.Length) % 2); i++)
            {
                line.Append(" ");
            }
            line.Append(sideBorder);

            return line.ToString();
        }
    }
}
