using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class Logger : ILogger
    {
        readonly string _file;
        public Logger(string file)
        {
            _file = file;
        }

        public void LogStart()
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Program started{Environment.NewLine}");
        }

        public void LogExit()
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Program terminated{Environment.NewLine}");
        }

        public void Error(Exception ex)
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Exception has been thrown: {ex} {Environment.NewLine}");
        }
        public void Error(Exception ex, string message)
        {
            File.AppendAllText(_file, $"{System.DateTime.Now} - Exception has been thrown: {ex} {Environment.NewLine}");
            File.AppendAllText(_file, $"{System.DateTime.Now} - {message} {Environment.NewLine}");
        }
    }
}
