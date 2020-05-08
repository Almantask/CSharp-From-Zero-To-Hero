using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    public class Logger : ILogger
    {
        private readonly ILogger _logger;
        private LogTarget _logTarget;
        public string GetLogTarget()
        {
            return _logTarget.ToString();
        }

        public Logger(LogTarget target)
        {
            _logTarget = target;

            if (target == LogTarget.Console)
            {
                _logger = new ConsoleLogger();
            }
            else if (target == LogTarget.File)
            {
                _logger = new FileLogger();
            }
        }

        public void Log(string message)
        {
            _logger.Log(message);
        }

        public void LogError(string message)
        {
            _logger.LogError(message);
        }
    }
}
