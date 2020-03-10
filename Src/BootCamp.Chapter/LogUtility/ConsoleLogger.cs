using System;

namespace BootCamp.Chapter.LogUtility
{
    class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
