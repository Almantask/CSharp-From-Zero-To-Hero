using System;
using System.Collections.Generic;
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
            if (message.Length == 0)
            {
                return "";
            }
            // make a array so I can find the longest word. 

            var arrayOfLines = message.Split(Environment.NewLine);

            // Find length of longest word 
            var lengthLongestWord = 0;

            if (arrayOfLines.Length == 1)
            {
                lengthLongestWord = arrayOfLines[0].Length;
            }
            else
            {
                foreach (var word in arrayOfLines)
                {
                    if (word.Length > lengthLongestWord)
                    {
                        lengthLongestWord = word.Length;
                    }
                }
            }

            // print table 

            var table = new StringBuilder() ; 
            // print header
            table = DisplayTopOrBottomLine(padding, lengthLongestWord, table);

            // print empty lines
            table = DisplayEmptyLines(padding, lengthLongestWord, table);

            // print text 

            foreach (var word in arrayOfLines)
            {
                table.Append( "|");
                table.Append (String.Empty.PadRight(padding, ' '));
                table.Append(word);
                table.Append(String.Empty.PadRight(lengthLongestWord - word.Length + padding, ' '));
                table.Append("|");
                table.Append(Environment.NewLine);

            }

            // print empty lines 

            table = DisplayEmptyLines(padding, lengthLongestWord, table);

            // print bottom 

            table = DisplayTopOrBottomLine(padding, lengthLongestWord, table) ;


            return table.ToString();

        }

        private static StringBuilder DisplayEmptyLines(int padding, int lengthLongestWord, StringBuilder table)
        {
            for (int i = 0; i < padding; i++)
            {
                table.Append("|");
                table.Append($"{ String.Empty.PadRight(lengthLongestWord + 2 * padding, ' ')}");
                table.Append( "|");
                table.Append($"{Environment.NewLine}");
            }

            return table;
        }

        private static StringBuilder DisplayTopOrBottomLine(int padding, int lengthLongestWord, StringBuilder table)
        {
            table.Append( "+");
            table.Append($"{String.Empty.PadRight(lengthLongestWord + 2 * padding, '-')}");
            table.Append("+");
            table.Append($"{Environment.NewLine}");
            return table;
        }
    }
}
