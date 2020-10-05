using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        public void LogMessage(DateTime dateTime, string message)
        {
            string fullFileName = GlobalSettings.filePath + @"\log.txt";
            string[] logEntry = new string[2];

            logEntry[0] = dateTime.ToString();
            logEntry[1] = message;

            try
            {
                File.AppendAllLines(fullFileName, logEntry);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
