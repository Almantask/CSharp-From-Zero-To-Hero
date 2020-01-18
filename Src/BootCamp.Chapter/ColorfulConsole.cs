using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ColorfulConsole
    {
        public static void Print(string message, ConsoleColor newColor)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }
    }
}
