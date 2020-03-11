using System;

namespace BootCamp.Chapter
{
    public interface ILog
    {
        public void LogOpenProgram();
        public void LogCloseProgram();
        public void LogCrash(Exception e);

        public abstract void LogNow(string text);
    }
}
