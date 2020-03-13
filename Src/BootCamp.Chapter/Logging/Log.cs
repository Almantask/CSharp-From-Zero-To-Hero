using System;

namespace BootCamp.Chapter.Logging
{
    abstract class Log : ILog
    {
        public void LogWithTime(string text)
        {
            LogNow($"{text} {DateTime.Now}");
        }

        public abstract void LogNow(string text);
        public abstract string Type();
    }

}
