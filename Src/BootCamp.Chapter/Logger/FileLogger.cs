using System;
using System.IO;

namespace BootCamp.Chapter.Logger
{
    public class FileLogger : ILogger
    {
        private readonly string _file;

        public void Log(string message)
        {
            File.AppendAllText(_file, $"{message}{Environment.NewLine}");
        }

        public void Info(string message)
        {
            Print(message, "INFO");
        }

        public void Warn(string message)
        {
            Print(message, "WARNING");
        }

        public void Error(string message)
        {
            Print(message, "ERROR");
        }

        public void Fatal(string message)
        {
            Print(message, "FATAL");
        }

        public FileLogger(string file)
        {
            _file = file;
        }

        private void Print(string message, string level)
        {
            var log = $"{level} {message}{Environment.NewLine}";
            File.AppendAllText(_file, log);
        }
    }
}