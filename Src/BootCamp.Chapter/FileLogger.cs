using System;
using System.IO;

namespace BootCamp.Chapter
{
    class FileLogger : ILogger
    {
        readonly string _file;
        public FileLogger(string file)
        {
            _file = file;
        }

        public void LogStart()
        {
            File.AppendAllText(_file, Environment.NewLine);
            File.AppendAllText(_file, $"{System.DateTime.Now} - Program start{Environment.NewLine}");
        }

        public void LogExit()
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Program exit{Environment.NewLine}");
        }

        public void Error(Exception ex)
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Exception has been thrown: {ex} {Environment.NewLine}");
        }
        public void Error(Exception ex, string message)
        {
            Error(ex);
            File.AppendAllText(_file, $"{System.DateTime.Now} - {message} {Environment.NewLine}");
        }
    }
}
