using System;
using System.Collections.Generic;
using System.Globalization;
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
            var output = symbol switch
            {
                'W' => '↥',
                'w' => '↥',
                'A' => '↤',
                'a' => '↤',
                'S' => '↧',
                's' => '↧',
                'D' => '↦',
                'd' => '↦',
                _  => '↥',
            };
            return output; 
        }

        public static void Print()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Give a a W, A, S or D");
            var isValid = char.TryParse(Console.ReadLine().ToUpper(new CultureInfo("en-US", false)), out char charTobeConverted);
            if (!isValid)
            {
                Console.WriteLine("You only allowed to enter 1 char");
            }
            Console.WriteLine(ArrowMovement.GetIndicator(charTobeConverted));
        }



    }
}
