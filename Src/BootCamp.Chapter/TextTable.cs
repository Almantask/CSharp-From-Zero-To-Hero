using System;


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
            if (message.Length == 0 || message == null) return "";

            string[] text = message.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            int max = 0;
            foreach (var number in text)
            {
                if (number.Length > max)
                {
                    max = number.Length;
                }
            }



            string tabs = new string('-', max + (padding*2));
            string first = $"+{tabs}+\r\n";
            string last = $"+{tabs}+\r\n";
            string newline = new string(' ', tabs.Length);
            string spaces = new string(' ', padding);

            string second = "";
            string third = "";



            if (padding > 0)
            {
                second = $"|{newline}|\r\n";
                third = $"|{spaces}{message}{spaces}|\r\n";
            }
            else
            {
                third = $"|{message}|\r\n";
            }

            if (padding > 0) return $"{first}{second}{third}{second}{last}";

            return $"{first}{third}{last}";
        }
    }
}
