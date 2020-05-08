using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    public class FileLogger : ILogger
    {
        private readonly string _logName = $"{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.log";
        private const string logsFolder = @"../../LogFiles/";

        public void Log(string message)
        {
            File.AppendAllText($"{logsFolder}{_logName}", message);
        }

        public void LogError(string message)
        {
            File.AppendAllText($"{logsFolder}{_logName}", $"Error Encountered: {message}");
        }
    }
}
