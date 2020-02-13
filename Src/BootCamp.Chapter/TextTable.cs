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
            
            var messageSplit = message.Split(Environment.NewLine);
            int messageWidth = MaxLength(messageSplit);
            int tableWidth = 2 * padding + messageWidth;
            
            // Making the top and bottom line of the box
            var sbTableTop = new StringBuilder();
            sbTableTop.Append("+");
            for(int i = 0; i<tableWidth; i++)
            {
                sbTableTop.Append("-");
            }
            sbTableTop.Append($"+{Environment.NewLine}");

            // Maxing the empty lines from the padding
            var sbTableEmpty = new StringBuilder();
            sbTableEmpty.Append("|");
            for (int i = 0; i < tableWidth; i++)
            {
                sbTableEmpty.Append(" ");
            }
            sbTableEmpty.Append($"|{Environment.NewLine}");

            // Making the left padded side of a line with text
            var sbTableLeft = new StringBuilder();
            sbTableLeft.Append("|");
            for (int i = 0; i<padding; i++)
            {
                sbTableLeft.Append(" ");
            }

            // Making the right padded side of a line with text
            var sbTableRight = new StringBuilder();
            for (int i = 0; i < padding; i++)
            {
                sbTableRight.Append(" ");
            }
            sbTableRight.Append($"|{Environment.NewLine}");

            var sbTable = new StringBuilder();

            sbTable.Append(sbTableTop);

            for(int i = 0; i< padding; i++)
            {
                sbTable.Append(sbTableEmpty);
            }
            
            foreach(string line in messageSplit)
            {
                sbTable.Append(sbTableLeft);
                sbTable.Append(line.PadRight(messageWidth));
                sbTable.Append(sbTableRight);
            }

            for (int i = 0; i < padding; i++)
            {
                sbTable.Append(sbTableEmpty);
            }

            sbTable.Append(sbTableTop);

            return sbTable.ToString();
        }

        /// <summary>
        /// Gets an array of strings and returns the length of the longest string in the array
        /// </summary>
        /// <param name="array"> array of strings </param>
        /// <returns> length of the longest string </returns>
        public static int MaxLength(string[] array)
        {
            int currentMax = 0;
            foreach(string item in array)
            {
                if (item.Length > currentMax)
                {
                    currentMax = item.Length;
                }
            }
            return currentMax;
        }
    }
}
