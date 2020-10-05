using System;

namespace BootCamp.Chapter
{
    public interface ILogger
    {
        void LogMessage(DateTime dateTime, string message);
    }
}
