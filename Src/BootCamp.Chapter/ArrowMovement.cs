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
                    return '↥';
                case 'w':
                    return '↥';
                case 'C':
                    return '↥';
                case 'c':
                    return '↥';
                case 'A':
                    return '↤';
                case 'a':
                    return '↤';
                case 'S':
                    return '↧';
                case 's':
                    return '↧';
                case 'D':
                    return '↦';
                case 'd':
                    return '↦';
            }
            return symbol;
        }
    }
}
