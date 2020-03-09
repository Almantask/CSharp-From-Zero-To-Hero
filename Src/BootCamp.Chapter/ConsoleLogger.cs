using System;

namespace BootCamp.Chapter
{
    class ConsoleLogger : ILogger
    {
        public void Error(Exception ex)
        {
            Console.WriteLine($"{System.DateTime.Now} - Exception has been thrown: {ex} {Environment.NewLine}");
        }

        public void Error(Exception ex, string message)
        {
            Error(ex);
            Console.WriteLine(message);
        }

        public void LogExit()
        {
            Console.WriteLine($"{System.DateTime.Now} - Program exit");
        }

        public void LogStart()
        {
            Console.WriteLine($"{System.DateTime.Now} - Program start");
        }
    }
}
