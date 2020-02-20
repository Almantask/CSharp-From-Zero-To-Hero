using System;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Part 1.
    /// </summary>
    public class TextTable
    {
        private readonly string _message;
        private readonly string _padding;

        private readonly string divider = Environment.NewLine;

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
        public string Build(string message, int padding)
        {
            return "";
        }

        private int FindLongestWord(string message)
        {
            int size = 0;
            foreach(string word in message.Split(divider))
            {
                if(word.Length > size)
                {
                    size = word.Length;
                }
            }

            return size;
        }
    }
}
