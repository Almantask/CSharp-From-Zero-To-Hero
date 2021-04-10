using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }
}
