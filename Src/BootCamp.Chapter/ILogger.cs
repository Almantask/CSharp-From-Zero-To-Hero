using System;
using System.Collections.Generic;
using System.Text;

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
