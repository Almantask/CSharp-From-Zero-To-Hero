using System;

namespace LogLibrary
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.WriteLine($"Error encountered: {message}");
        }

        public void LogEvent(string message)
        {
            MoveCursor();
            Console.WriteLine(message);
            ResetCursor();
        }

        private static void MoveCursor()
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
        }

        private static void ResetCursor()
        {
            Console.SetCursorPosition(0, 0);
        }
    }
}