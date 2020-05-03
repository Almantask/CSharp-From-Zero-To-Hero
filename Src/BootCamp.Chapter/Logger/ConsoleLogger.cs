using System;

namespace BootCamp.Chapter.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Logger(string message, LogLevel logLevel)
        {
            if (!logLevel.Equals(LogLevel.Log))
            {
                Console.ForegroundColor = LogColor(logLevel);
                Console.Write($"[{logLevel}] ");
                Console.ResetColor();
            }
            Console.Write(message);
            Console.WriteLine();
        }
        
        private ConsoleColor LogColor(LogLevel logLevel)
        {
            return logLevel switch
            {
                LogLevel.Log => ConsoleColor.White,
                LogLevel.Info => ConsoleColor.DarkCyan,
                LogLevel.Warn => ConsoleColor.DarkYellow,
                LogLevel.Error => ConsoleColor.Red,
                LogLevel.Fatal => ConsoleColor.DarkMagenta,
                _ => ConsoleColor.White
            };
        }
    }
}