namespace BootCamp.Chapter.Logging
{
    abstract class Log : ILog
    {
        public abstract void LogNow(string text);
        public abstract string Type();
    }

}
