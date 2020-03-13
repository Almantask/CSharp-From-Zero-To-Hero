using System;

namespace BootCamp.Chapter.Logging
{
    abstract class Log : ILog
    {
        /// <summary>
        /// Will log "{text} {DateTime.Now}"
        /// </summary>
        /// <param name="text"></param>
        public void LogWithTime(string text)
        {
            LogNow($"{text} {DateTime.Now}");
        }
        /// <summary>
        /// This will log a crash with Reason.
        /// </summary>
        /// <param name="e"></param>
        public void LogCrash(Exception e)
        {
            LogNow($"Program Crashed Time: {DateTime.Now}\r\nReason: {e.Message}");
        }
        /// <summary>
        /// This will log Anything (text) to disired place.
        /// </summary>
        /// <param name="text"></param>
        public abstract void LogNow(string text);

        public abstract string Type();
    }

}
