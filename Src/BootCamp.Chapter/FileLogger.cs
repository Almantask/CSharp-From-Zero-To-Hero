using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        private readonly string logFile = $"Log_{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.log";
        private string _message;

        public void SetMessage(string message)
        {
            _message = message;
        }

        public FileLogger()
        {
        }

        public FileLogger(string message)
        {
            _message = message;
        }

        public void Log()
        {
            using StreamWriter logWriter = new StreamWriter(logFile, true);
            logWriter.WriteLine(_message);
            logWriter.Close();
        }
    }
}