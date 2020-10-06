using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // LogType.FileLog writes to file, LogType.ConsoleLog writes to console.
            ILogger logger = GlobalSettings.CreateLog(LogType.ConsoleLog);
            logger.LogMessage($"{DateTime.Now} notice: Main program start");

            ReadAndWriteData readAndWriteData = new ReadAndWriteData();
            readAndWriteData.ReadAndWritePersonData(logger);
            readAndWriteData.ReadAndWritePersonData(logger);

            logger.LogMessage($"{DateTime.Now} notice: Main program end");
        }
    }
}