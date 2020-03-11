using System;

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
