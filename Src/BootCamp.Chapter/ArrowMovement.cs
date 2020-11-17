using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ArrowMovement
    {
        /// <summary>
        /// Use your WASD (both capital and non capital) keys to print arrows  
        /// W- ↥  
        /// A- ↤  
        /// S- ↧  
        /// D- ↦
        /// Not case sensitive.
        /// </summary>
        /// <param name="symbol">Either of WASD character.</param>
        /// <returns>One of the arrow characters. '↥' by default.</returns>
        public static char GetIndicator(char symbol)
        {
            string input = symbol.ToString().ToUpper();
            string output;
            switch (input)
            {
                case "W":
                    output = EncodingKey("↥");
                    break;
                case "A":
                    output = EncodingKey("↤");
                    break;
                case "S":
                    output = EncodingKey("↧");
                    break;
                case "D":
                    output = EncodingKey("↦");
                    break;
                default:
                    output = EncodingKey("↥");
                    break;
            }
            return Convert.ToChar(output);
        }
        private static string EncodingKey(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            string result = Encoding.Default.GetString(bytes);
            return result;
        }
    }
}
