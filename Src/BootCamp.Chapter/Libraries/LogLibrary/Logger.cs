using UtilsLibrary;

namespace LogLibrary
{
    public enum LogTarget
    {
        File,
        Console,
    }

    public static class Logger
    {
        private static ILogger _logger;
        private static LogTarget _target;

        public static void SetTarget(LogTarget target)
        {
            _target = target;
        }

        public static void Log(string message)
        {
            if (!Utils.IsValid(message))
            {
                return;
            }

            CheckTarket();

            _logger.Log(message);
        }

        public static void LogError(string message)
        {
            if (!Utils.IsValid(message))
            {
                return;
            }

            CheckTarket();

            _logger.LogError(message);
        }

        private static void CheckTarket()
        {
            if (_target == LogTarget.File)
            {
                _logger = new FileLogger();
            }
            else if (_target == LogTarget.Console)
            {
                _logger = new ConsoleLogger();
            }
        }
    }
}