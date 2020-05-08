using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now} - {message}");
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{DateTime.Now} - Error Encountered: {message}");

            Console.ResetColor();
        }
    }
}
