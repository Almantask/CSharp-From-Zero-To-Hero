using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileLogger : ILogger
    {
        private readonly string _logFileName;

        public FileLogger()
        {
            _logFileName = CreateLogFile();
            ActionLog("Log File created");
        }

        public void ActionLog(string action)
        {
            using (var writer = File.AppendText(_logFileName))
            {
                writer.WriteLine($"[{DateTime.Now}] {action}");
            }
        }

        public void ErrorLog(Exception error)
        {
            using (var writer = File.AppendText(_logFileName))
            {
                writer.WriteLine($"[{DateTime.Now}] {error}");
            }
        }

        private string CreateLogFile()
        {
            Directory.CreateDirectory("Logs");
            var currTime = DateTime.Now.ToString().Replace("/", "_").Replace(" ", "_").Replace(":", "_");
            var logFileName = @$"{Directory.GetCurrentDirectory()}\Logs\{currTime}.log";
            using (File.Create(logFileName))
            return logFileName;
            
        }
    }
}
