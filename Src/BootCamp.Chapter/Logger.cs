using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Logger
    {
        public Menu Menu { get; }

        public Logger(Menu menu)
        {
            Menu = menu;
            menu.OnMenuKeyPressed += (object sender, LoggerArgs args) =>
            {
                LogToConsole(args.Message);
            };
        }

        public void LogToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
