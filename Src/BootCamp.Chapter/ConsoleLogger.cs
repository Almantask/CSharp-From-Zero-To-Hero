using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ConsoleLogger : Illogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{ message}");
        }
    }
}
