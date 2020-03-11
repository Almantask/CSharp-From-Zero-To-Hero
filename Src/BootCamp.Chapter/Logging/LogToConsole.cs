using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    class LogToConsole : Log
    {
        public override void LogNow(string text)
        {
            Console.WriteLine(text);
        }
    }
}
