using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Logger
    {
        public Demo Demo { get; }
        public Menu Menu { get; }

        public Logger(Demo demo, Menu menu)
        {
            Demo = demo;
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
