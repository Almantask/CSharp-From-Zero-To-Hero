using System.IO;

namespace BootCamp.Chapter.Logger
{
    class FileLogger : ILogger
    {
        string _logPath;
        public FileLogger(string LogPath)
        {
            _logPath = LogPath;
        }

        public void Log(string msg)
        {
            File.AppendAllText(_logPath, msg + "\r\n");
        }
    }
}
