using System;
using System.Threading;

namespace BootCamp.Chapter.Logger
{
    public class LogConsole : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Print(message, "INFO", ConsoleColor.DarkCyan);
        }

        public void Warn(string message)
        {
            Print(message, "WARNING", ConsoleColor.DarkYellow);
        }

        public void Error(string message)
        {
            Print(message, "ERROR", ConsoleColor.Red);
        }

        public void Fatal(string message)
        {
            Print(message, "FATAL", ConsoleColor.DarkMagenta);
        }

        private void Print(string message, string level, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write($"[{level}] ");
            Console.ResetColor();
            Console.Write(message);
            Console.WriteLine();
            Thread.Sleep(5);
        }
    }
}