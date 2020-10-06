using System;

namespace BootCamp.Chapter
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{message}");
        }
    }
}
