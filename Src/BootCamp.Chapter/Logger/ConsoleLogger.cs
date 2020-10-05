using System;

namespace BootCamp.Chapter
{
    public class ConsoleLogger : ILogger
    {
        public void LogMessage(DateTime dateTime, string message)
        {
            Console.WriteLine($"{dateTime}, {message}");
        }
    }
}
