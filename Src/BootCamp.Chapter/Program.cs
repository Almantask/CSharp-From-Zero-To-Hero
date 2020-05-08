using BootCamp.Chapter.Logging;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log("Application started");
            consoleLogger.LogError("Critical failure");
            consoleLogger.Log("Closing application");

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log("Application started");
            fileLogger.LogError("Critical failure");
            fileLogger.Log("Closing application");
        }
    }
}
