using System;

namespace BootCamp.Chapter
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Error encountered: {message}");
        }
    }
}