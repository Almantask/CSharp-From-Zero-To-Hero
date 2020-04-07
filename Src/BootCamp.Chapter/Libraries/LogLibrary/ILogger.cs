namespace LogLibrary
{
    public interface ILogger
    {
        void Log(string message);

        void LogError(string message);

        void LogEvent(string message);
    }
}