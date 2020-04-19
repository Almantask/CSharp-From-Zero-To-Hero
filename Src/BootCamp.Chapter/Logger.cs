using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Logger
    {
        public Demo Demo { get;}

        public Logger(Demo demo)
        {
            Demo = demo;
            Demo.logEventHandler += (object sender, LoggerArgs args) =>
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
