using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Logging
{
    public static class LoggerFactory
    {
        public static FileLogger CreateFileLogger()
        {
            return new FileLogger();
        }

        public static ConsoleLogger CreateConsoleLogger()
        {
            return new ConsoleLogger();
        }
    }
}
