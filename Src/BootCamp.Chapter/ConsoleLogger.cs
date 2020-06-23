using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            LogAction("Log started");
        }
        public void LogAction(string action)
        {
            Console.WriteLine($"[{DateTime.Now}] {action}");
        }

        public void LogError(Exception error)
        {
            Console.WriteLine($"[{DateTime.Now}] {error}");
        }
    }
}
