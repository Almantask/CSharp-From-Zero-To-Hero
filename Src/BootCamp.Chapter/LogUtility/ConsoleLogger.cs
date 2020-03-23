using System;

namespace BootCamp.Chapter.LogUtility
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
