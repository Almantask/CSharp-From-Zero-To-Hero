using System;

namespace BootCamp.Chapter.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Logger(string message, Log.Level logLevel)
        {
            if (!logLevel.Equals(Log.Level.Log))
            {
                Console.ForegroundColor = LogColor(logLevel);
                Console.Write($"[{logLevel}] ");
                Console.ResetColor();
            }
            Console.Write(message);
            Console.WriteLine();
        }
        
        private ConsoleColor LogColor(Log.Level logLevel)
        {
            return logLevel switch
            {
                Log.Level.Log => ConsoleColor.White,
                Log.Level.Info => ConsoleColor.DarkCyan,
                Log.Level.Warn => ConsoleColor.DarkYellow,
                Log.Level.Error => ConsoleColor.Red,
                Log.Level.Fatal => ConsoleColor.DarkMagenta,
                _ => ConsoleColor.White
            };
        }
    }
}