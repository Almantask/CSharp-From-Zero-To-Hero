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
            return ConvertKeyToArrow(symbol);
        }
        public static void Demo()
        {
            char keyStroke = RequestKeyStroke();
            while (IsValidKey(keyStroke))
            {
                char arrow = ConvertKeyToArrow(keyStroke);
                DisplayResult(arrow);
                keyStroke = RequestKeyStroke();
            }
            Console.WriteLine("You pressed an incorrect key. Keep practicing!");
        }

        private static char RequestKeyStroke()
        {
            Console.WriteLine("Please enter W, A, S or D to practice your First Person Shooter moves.");
            return Console.ReadKey(true).KeyChar;
        }

        private static bool IsValidKey(char keyStroke)
        {
            char[] expectedKeys = { 'w', 'W', 'A', 'a', 's', 'S', 'd', 'D' };
            foreach (char letter in expectedKeys)
            {
                if (keyStroke == letter)
                {
                    return true;
                }
            }
            return false;

        }
        private static char ConvertKeyToArrow(char keyStroke)
        {
            if (char.ToUpper(keyStroke) == 'W')
            {
                return '↥';
            }
            if (char.ToUpper(keyStroke) == 'S')
            {
                return '↧';
            }
            if (char.ToUpper(keyStroke) == 'A')
            {
                return '↤';
            }
            if (char.ToUpper(keyStroke) == 'D')
            {
                return '↦';
            }
            return '↥';
        }
        private static void DisplayResult(char newImage)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(newImage);
        }
    }
}

