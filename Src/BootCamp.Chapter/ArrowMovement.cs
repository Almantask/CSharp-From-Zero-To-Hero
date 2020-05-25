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
            switch (symbol)
            {
                case 'W':
                    return '\u21a5';
                case 'w':
                    return '\u21a5';
                case 'A':
                    return '\u21A4';
                case 'a':
                    return '\u21A4';
                case 'D':
                    return '\u21A6';
                case 'd':
                    return '\u21A6';
                case 'S':
                    return '\u21A7';
                case 's':
                    return '\u21A7';
                case 'C':
                    return '\u21a5';
                case 'c':
                    return '\u21a5';
            }

            return 'a';
        }
    }
}
