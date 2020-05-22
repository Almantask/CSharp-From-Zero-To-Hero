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
            if (string.IsNullOrEmpty(message))
            {
                return "";
            }
            string returnMessage = "";
            int longestWordLength = FindLongestWordLength(message);
            returnMessage += (CreateRow(longestWordLength, padding));
            returnMessage += CreateEmptyRow(padding, longestWordLength);
            returnMessage += WriteMessage(message, padding, longestWordLength);
            returnMessage += CreateEmptyRow(padding, longestWordLength);
            returnMessage += CreateRow(longestWordLength, padding);
            Console.WriteLine(returnMessage);
            return returnMessage;
        }

        private static string WriteMessage(string message, int padding, int longestWordLength)
        {
            string returnMessage = "";
            string[] words = message.Split("\r\n");
            if (words.Length > 1)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    string rowMessage = words[i];
                    if (longestWordLength > rowMessage.Length)
                    {
                        if (padding > 0)
                        {
                            string leftPipe = "|".PadRight(padding + 1);
                            string rightPipe = "|".PadLeft(padding + (longestWordLength - rowMessage.Length + 1));
                            returnMessage += ($"{leftPipe}{rowMessage}{rightPipe}\r\n");
                        }
                        else
                        {
                            string leftPipe = "|";
                            string rightPipe = "|".PadLeft(longestWordLength - rowMessage.Length + 1); ;
                            returnMessage += ($"{leftPipe}{rowMessage}{rightPipe}\r\n");
                        }
                    }
                    else
                    {
                        if (padding > 0)
                        {
                            string leftPipe = "|".PadRight(padding + 1);
                            string rightPipe = "|".PadLeft(padding + 1);
                            returnMessage += ($"{leftPipe}{rowMessage}{rightPipe}\r\n");
                        }
                        else
                        {
                            returnMessage += ($"|{rowMessage}|\r\n");
                        }
                    }

                }
            }
            else
            {
                if (padding > 0)
                {
                    string leftPipe = "|".PadRight(padding + 1);
                    string rightPipe = "|".PadLeft(padding + 1);
                    return $"{leftPipe}{words[0]}{rightPipe}\r\n";
                }
                else
                {
                    return ($"|{words[0]}|\r\n");
                }
            }
            return returnMessage;
        }

        private static string CreateEmptyRow(int padding, int longestWordLength)
        {
            string returnMessage = "";
            int emptyRowLength = longestWordLength + (padding * 2);
            string spaces = "";
            spaces = spaces.PadRight(emptyRowLength);
            if (padding > 0)
            {
                for (int i = 0; i < padding; i++)
                {
                    returnMessage = $"|{spaces}|\r\n";
                }
            }
            return returnMessage;
        }

        private static string CreateRow(int longestWordLength, int padding)
        {
            int RowLength = longestWordLength + padding * 2;
            string dashes = "";
            for (int i = 0; i < RowLength; i++)
            {
                dashes += "-";
            }
            return($"+{dashes}+\r\n");
        }

        private static int FindLongestWordLength(string message)
        {
            string[] words = message.Split("\r\n");
            if (words.Length > 1)
            {
                string longestWord = words[0];
                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > words[i - 1].Length)
                    { 
                        longestWord = words[i];
                    }
                }
                return longestWord.Length;
            }
            else
            {
                return words[0].Length;
            }
            

            return 0;
        }
    }
}
