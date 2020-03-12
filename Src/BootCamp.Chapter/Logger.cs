namespace BootCamp.Chapter
{
    public enum LogTarget
    {
        File,
        Console,
        Error
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
            if (!StringOps.IsStringValid(message))
            {
                return;
            }

            if (_target == LogTarget.File)
            {
                _logger = new FileLogger();
            }
            else if (_target == LogTarget.Console)
            {
                _logger = new ConsoleLogger();
            }

            _logger.Log(message);
        }
    }
}