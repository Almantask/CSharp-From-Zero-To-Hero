namespace BootCamp.Chapter
{
    public enum LogTarget
    {
        File,
        Console
    }

    public static class Logger
    {
        private static ILogger _logger;
        private static LogTarget _target = LogTarget.Console;
        private static string _message;

        public static void SetTarget(LogTarget target)
        {
            _target = target;
        }

        public static void SetMessage(string message)
        {
            _message = message;
        }

        public static string GetMessage()
        {
            return _message;
        }

        public static void Log(string message)
        {
            if (!StringOps.IsStringValid(message))
            {
                return;
            }

            if (_target == LogTarget.File)
            {
                _logger = new FileLogger(message);
            }
            else if (_target == LogTarget.Console)
            {
                _logger = new ConsoleLogger(message);
            }

            _logger.Log();
        }
    }
}