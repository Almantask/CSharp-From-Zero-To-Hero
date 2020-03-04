using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileLogger : Illogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"logs/log.txt", message);
        }
    }
}
