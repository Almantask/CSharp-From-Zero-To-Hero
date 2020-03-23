using System;
using System.IO;

namespace BootCamp.Chapter.LogUtility
{
    public class FileLogger : ILogger
    {
        private string _logPath;

        public FileLogger(string logPath)
        {
            _logPath = logPath;
            File.Delete(logPath);
        }

        public void Log(string msg)
        {
            File.AppendAllText(_logPath, msg + Environment.NewLine);
        }
    }
}
