using System;

namespace BootCamp.Chapter.Logger
{
    class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
