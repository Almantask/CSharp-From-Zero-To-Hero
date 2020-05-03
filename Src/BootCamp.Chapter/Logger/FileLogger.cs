using System;
using System.IO;

namespace BootCamp.Chapter.Logger
{
    public class FileLogger : ILogger
    {
        private readonly string _file;

        public void Logger(string message, LogLevel logLevel)
        {
            var messageToLog = logLevel.Equals(LogLevel.Log) ? message : $"[{logLevel}] {message}";
            File.AppendAllText(_file, messageToLog + Environment.NewLine);
        }
        
        public FileLogger(string file)
        {
            _file = file;
        }
    }
}