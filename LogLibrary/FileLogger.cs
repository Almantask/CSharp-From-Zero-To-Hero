using System;
using System.IO;

namespace LogLibrary
{
    public class FileLogger : ILogger
    {
        private readonly string logFile = $"Log_{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.log";

        public void Log(string message)
        {
            using StreamWriter logWriter = new StreamWriter(logFile, true);
            logWriter.WriteLine(message);
            logWriter.Close();
        }

        public void LogError(string message)
        {
            using StreamWriter logWriter = new StreamWriter(logFile, true);
            logWriter.WriteLine($"Error encountered: {message}");
            logWriter.Close();
        }
    }
}