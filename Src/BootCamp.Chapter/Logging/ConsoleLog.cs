using System;

namespace BootCamp.Chapter.Logging
{
    class ConsoleLog : ILog
    {
        public void LogNow(string text)
        {
            Console.WriteLine($"{DateTime.Now}: {text}");
        }

        public string Type()
        {
            return "Console";
        }
    }
}
