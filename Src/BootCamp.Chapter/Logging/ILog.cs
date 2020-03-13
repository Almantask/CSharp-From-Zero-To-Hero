using System;

namespace BootCamp.Chapter
{
    public interface ILog
    {
        /// <summary>
        /// Gives back a string with the Type of logger used.
        /// </summary>
        /// <returns></returns>
        public abstract string Type();
        /// <summary>
        /// Will log "{text} {DateTime.Now}".
        /// </summary>
        /// <param name="text"></param>
        public void LogWithTime(string text);
        /// <summary>
        /// This will log Anything (text) to disired Logger.
        /// </summary>
        /// <param name="text"></param>
        public abstract void LogNow(string text);
    }
}
