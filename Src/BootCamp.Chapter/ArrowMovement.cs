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
            string showArrow;
            string arrowCode = symbol.ToString().ToUpper();
            
            switch (arrowCode)
            {
                case "W":
                    showArrow = ("\u21A5");
                    break;
                case "A":
                    showArrow = ("\u21A4");
                    break;
                case "S":
                    showArrow = ("\u21A7");
                    break;
                case "D":
                    showArrow = ("\u21A6");
                    break;
                default:
                    showArrow = ("\u21A5");
                    break;
            }
            return Convert.ToChar(showArrow);
        }
    }
}