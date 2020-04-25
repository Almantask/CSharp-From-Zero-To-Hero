namespace BootCamp.Chapter.Logger
{
    public interface ILogger
    {
        public void Log(string message);
        public void Info(string message);
        public void Warn(string message);
        public void Error(string message);
        public void Fatal(string message);
    }
}