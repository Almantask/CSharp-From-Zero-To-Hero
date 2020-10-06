using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        public void LogMessage(string message)
        {
            string fullFileName = GlobalSettings.filePath + @"\log.txt";

            List<string> entries = new List<string>();
            entries.Add(message);

            try
            {
                File.AppendAllLines(fullFileName, entries);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to file: {ex.Message}");
            }
        }
    }
}
