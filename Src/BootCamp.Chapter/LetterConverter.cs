using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class LetterConverter
    {
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

        private static bool IsValidKey (char keyStroke)
        {
            char[] expectedKeys = { 'w', 'W', 'A', 'a', 's', 'S', 'd', 'D' }; 
            foreach (char letter in expectedKeys)
            {
                if (keyStroke == letter)
                    return true;
            }
            return false;

        }
        private static char ConvertKeyToArrow (char keyStroke)
        {
            if (char.ToUpper(keyStroke) == 'W')
                return '\u2191';
            if (char.ToUpper(keyStroke) == 'S')
                return '\u2193';
            if (char.ToUpper(keyStroke) == 'A')
                return '\u2190';
            if (char.ToUpper(keyStroke) == 'D')
                return '\u2192';
            return 'E';
        }
        private static void DisplayResult(char newImage)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(newImage);
        }
    }
}
