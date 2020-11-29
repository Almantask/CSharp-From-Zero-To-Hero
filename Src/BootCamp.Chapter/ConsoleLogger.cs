using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ConsoleLogger:ILog
    {
        public void WriteMessage(string message)
        {
            var oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = oldColor;
        }
    }
}
