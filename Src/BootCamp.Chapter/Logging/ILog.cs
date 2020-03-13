using System;

namespace BootCamp.Chapter
{
    public interface ILog
    {
        public abstract string Type();
        public void LogWithTime(string text);
        public void LogCrash(Exception e);

        public abstract void LogNow(string text);
    }
}
