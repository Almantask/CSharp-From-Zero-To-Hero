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
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            var input = symbol;
            input = char.ToLower(input);

            char output = '↥';
            var upArrow = '↥';
            var downArrow = '↧';
            var leftArrow = '↤';
            var rightArrow = '↦';

            switch (input)
            {
                case 'a':
                    output = leftArrow;
                    break;
                case 'd':
                    output = rightArrow;
                    break;
                case 'w':
                    output = upArrow;
                    break;
                case 's':
                    output = downArrow;
                    break;
                default:
                    output = upArrow;
                    break;
            }

            return output;
        }
    }
}
