using BootCamp.Chapter.Logger;
using System.IO;

namespace BootCamp.Chapter
{
    public class LogMessage
    {
        private const string LogPath = @"..\..\..\Output\Log.txt";

        public LogMessage()
        {
            File.Delete(LogPath);
        }

        private const int ConsoleLogger = 1;
        private const int FileLogger = 2;
        private int LogOption = FileLogger; //Set to either ConsoleLogger or FileLogger
        private ILogger _logger;

        public void Log(string msg)
        {
            switch (LogOption)
            {
                case ConsoleLogger:
                    _logger = new ConsoleLogger();
                    break;
                case FileLogger:
                    _logger = new FileLogger(LogPath);
                    break;
                default:
                    throw new InvalidArgumentException(LogOption);
            }

            _logger.Log(msg);
        }
    }
}
