using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            ActionLog("Log started");
        }
        public void ActionLog(string action)
        {
            Console.WriteLine($"[{DateTime.Now}] {action}");
        }

        public void ErrorLog(string error)
        {
            Console.WriteLine($"[{DateTime.Now}] {error}");
        }
    }
}
