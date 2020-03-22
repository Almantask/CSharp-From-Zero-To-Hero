using System;
using System.IO;

namespace BootCamp.Chapter.LogUtility
{
    class FileLogger : ILogger
    {
        readonly string _logPath;
        public FileLogger(string LogPath)
        {
            _logPath = LogPath;
        }

        public void Log(string msg)
        {
            File.AppendAllText(_logPath, msg + Environment.NewLine);
        }
    }
}
