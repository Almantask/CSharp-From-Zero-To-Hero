using System;
using System.IO;

namespace BootCamp.Chapter
{
    public static class GlobalSettings
    {
        public static string filePath = Directory.GetCurrentDirectory();

        public static ILogger CreateLog(LogType logType)
        {
            switch (logType)
            {
                case LogType.ConsoleLog:
                    return new ConsoleLogger();
                case LogType.FileLog:
                    return new FileLogger();
                default:
                    return new ConsoleLogger();
            }
        }
    }
}
