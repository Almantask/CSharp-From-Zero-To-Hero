namespace BootCamp.Chapter.Logger
{
    public interface ILogger
    {
        public void Logger(string message, Log.Level logLevel);
    }
}