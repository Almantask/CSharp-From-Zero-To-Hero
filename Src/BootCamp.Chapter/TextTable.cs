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

            var arrayOfWords = message.Split(Environment.NewLine);

            // Find length of longest word 
           var longestWord = ""; 

            if (arrayOfWords.Length == 1)
            {
                longestWord = arrayOfWords[0]; 
            }
            else
            {
                switch (arrayOfWords[0].CompareTo(arrayOfWords[1]))
                {
                    case -1:
                        longestWord = arrayOfWords[1]; 
                        break;
                    default:
                        longestWord = arrayOfWords[0]; 
                        break;
                }
            }

            // print table 

            // print header
            var table = "+"; 
            table += $"{String.Empty.PadRight(longestWord.Length + 2 * padding , '-')}"; 
            table += "+"; 
            table +=$"{Environment.NewLine}";

            // print empty lines
            for (int i = 0; i < padding; i++)
            {
                table += "|"; 
                table += $"{ String.Empty.PadRight(longestWord.Length + 2 * padding, ' ')}";
                table += "|"; 
                table += $"{Environment.NewLine}";
            }

            // print text 

            foreach (var word in arrayOfWords)
            {
                table += "|";
                table += String.Empty.PadRight(padding, ' ');
                table += word;  
                table += String.Empty.PadRight(longestWord.Length - word.Length + padding, ' ');
                table += "|";
                table += Environment.NewLine; 

            }

            // print empty lines 

            for (int i = 0; i < padding; i++)
            {
                table += "|";
                table += $"{ String.Empty.PadRight(longestWord.Length + 2 * padding, ' ')}";
                table += "|";
                table += $"{Environment.NewLine} ";
            }

            // print bottom 

            table += "+";
            table += $"{String.Empty.PadRight(longestWord.Length + 2 * padding, '-')}";
            table += "+";
            table += $"{Environment.NewLine}";


            return table; 

        }
    }
}
