using System;

namespace BootCamp.Chapter
{
    interface ILogger
    {
        public void LogStart();
        public void LogExit();
        public void Error(Exception ex);
        public void Error(Exception ex, string message);
    }
}
