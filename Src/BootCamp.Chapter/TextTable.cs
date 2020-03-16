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
            if (string.IsNullOrEmpty(message))
            {
                return "";
            }

            string[] splitMessage = message.Split(new string[] { System.Environment.NewLine }, System.StringSplitOptions.None);
            StringBuilder sb = new StringBuilder();
            int longStringIndex = LongestStringIndex(splitMessage);

            sb = BuildTopOrBottom(sb, splitMessage[longStringIndex].Length + padding * 2);
            sb = BuildInnerPadding(sb, splitMessage[longStringIndex].Length + padding * 2, padding);
            sb = BuildInnerMessage(sb, splitMessage, longStringIndex, padding);
            sb = BuildInnerPadding(sb, splitMessage[longStringIndex].Length + padding * 2, padding);
            sb = BuildTopOrBottom(sb, splitMessage[longStringIndex].Length + padding * 2);
            return sb.ToString();
        }
        public static int LongestStringIndex(string[] message)
        {
            if (message.Length == 1)
            {
                return 0;
            }
            int index = 0;
            int max = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Length>max)
                {
                    max = message[i].Length;
                    index = i;
                }
            }
            return index;
        }
        
        public static StringBuilder BuildTopOrBottom(StringBuilder sb, int padding)
        {
            return sb.Append("+").Append('-', padding).AppendLine("+");
        }

        public static StringBuilder BuildInnerPadding(StringBuilder sb, int innerPadding, int padding)
        {
            for (int i = 0; i < padding; i++)
            {
                sb.Append("|").Append(' ', innerPadding).AppendLine("|");
            }
            return sb;
        }

        public static StringBuilder BuildInnerMessage(StringBuilder sb, string[] splitMessage, int longStringIndex,int padding)
        {
            for (int i = 0; i < splitMessage.Length; i++)
            {
                sb.Append("|").Append(' ', padding).Append(splitMessage[i]);
                sb.Append(' ', splitMessage[longStringIndex].Length - splitMessage[i].Length);
                sb.Append(' ', padding).AppendLine("|");
            }
            return sb;
        }
    }
}
