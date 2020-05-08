using BootCamp.Chapter.Logging;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger[] loggers = new ILogger[]
            {
                new ConsoleLogger(),
                new FileLogger()
            };

            UseLoggers(loggers, "Application Started", true);
        }


        private static void UseLoggers(ILogger[] loggers, string message, bool isError)
        {
            foreach (var logger in loggers)
            {
                if (isError)
                {
                    logger.LogError(message);
                }
                else
                {
                    logger.Log(message);
                }
            }
        }
    }
}
