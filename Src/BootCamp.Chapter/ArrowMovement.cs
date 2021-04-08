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
            char result = Convert.ToChar('\u21A5');
            string acceptedChars = "wasdWASD";
            if (acceptedChars.Contains(symbol))
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                if(symbol.Equals('w') || symbol.Equals('W'))
                {  
                    result = (char)'\u21A5';
                }
                else if (symbol.Equals('a') || symbol.Equals('A'))
                {
                    result = (char)'\u21A4';
                }
                else if (symbol.Equals('s') || symbol.Equals('S'))
                {
                    result = (char)'\u21A7';
                }
                else if (symbol.Equals('d') || symbol.Equals('D'))
                {
                    result = (char)'\u21A6';
                }
            }

            return result;
        }
    }
}
