using System;
using System.IO;

namespace BootCamp.Chapter.Logging
{
    abstract class Log : ILog
    {
        public void LogOpenProgram()
        {
            LogNow($"Program Started. Time: {DateTime.Now}");
        }
        public void LogCloseProgram()
        {
            LogNow($"Program Stopped. Time: {DateTime.Now}");
        }
        public void LogCrash(Exception e)
        {
            LogNow($"Program Crashed Time: {DateTime.Now}\r\nReason: {e.Message}");
        }
        public abstract void LogNow(string text);
    }

}
