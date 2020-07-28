using System;

namespace BootCamp.Chapter.Logger
{
    class ConsoleLogger : ILogger
    {
        public void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now} {message}");
        }
    }
}
