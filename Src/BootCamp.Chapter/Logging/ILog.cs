using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public interface ILog
    {
        public void LogOpenProgram();
        public void LogCloseProgram();
        public void LogCrash(Exception e);
    }
}
