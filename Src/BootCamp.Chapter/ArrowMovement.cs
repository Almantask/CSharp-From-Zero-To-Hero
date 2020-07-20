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
            if (symbol =='a' || symbol == 'A')
            {
                return '\u21A4';

            }
            if (symbol == 'd' || symbol == 'D')
            {
                return '\u21A6';
            }
            if (symbol == 'w' || symbol == 'W')
            {
                return '\u21A5';
            }
            if (symbol == 's' || symbol == 'S')
            {
                return '\u21A7';
            }

            return '-';
        }
    }
}
