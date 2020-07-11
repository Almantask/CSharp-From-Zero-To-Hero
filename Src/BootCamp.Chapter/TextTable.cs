
using System;
using System.Linq;
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
            string newMessage = message.Replace(System.Environment.NewLine, " ");

            if (String.IsNullOrEmpty(message))
            {
                return message;
            }

            StringBuilder buildMessage = new StringBuilder();
            buildMessage.AppendLine(CreateBorder(FindLongestWordLength(newMessage), padding));
            buildMessage.Append(CreateBody(newMessage, padding, FindLongestWordLength(newMessage)));
            buildMessage.AppendLine(CreateBorder(FindLongestWordLength(newMessage), padding));

            return buildMessage.ToString();
        }
        public static string CreateBody(string message, int padding, int messageLength)
        {
            var messageBody = new StringBuilder();

            if (padding > 0)
            {
                messageBody.Append(CreateEmptyLines(message, padding, messageLength));
                messageBody.Append(CreateMessage(message, padding, messageLength));
                messageBody.Append(CreateEmptyLines(message, padding, messageLength));
            }
            else
            {
                messageBody.Append(CreateMessage(message, padding, messageLength));
            }

            return messageBody.ToString();
        }
        public static string CreateBorder(int messageLength, int padding)
        {
            var topAndBottomBorder = new StringBuilder();
            topAndBottomBorder.Append('+').Append('-', padding).Append('-', messageLength).Append('-', padding).Append('+');
            return topAndBottomBorder.ToString();
        }

        public static string CreateEmptyLines(string message, int padding, int messageLength)
        {
            var emptyLines = new StringBuilder();

            for (int j = 0; j < padding; j++)
            {
                emptyLines.Append("|").Append(' ', padding).Append(' ', messageLength).Append(' ', padding).AppendLine("|");

            }
            return emptyLines.ToString();
        }

        public static string CreateMessage(string message, int padding, int messageLength)
        {
            var messageBody = new StringBuilder();
            string[] words = message.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                var emtySpace = messageLength - words[i].Length;
                messageBody.Append("|").Append(' ', padding).Append(words[i]).Append(' ', emtySpace).Append(' ', padding).AppendLine("|");
            }
            return messageBody.ToString();
        }

        public static int FindLongestWordLength(string message)
        {
            string[] words = message.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int length = 0;
            foreach (String s in words)
            {
                if (s.Length > length)
                {
                    word = s;
                    length = s.Length;
                }
            }
            return length;
        }
    }
}
