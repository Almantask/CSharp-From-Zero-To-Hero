using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        private string _filePath = "test.txt";
        
        public void Log(string message)
        {
            try
            {
                using var writer = new StreamWriter(_filePath, true);
                writer.WriteLine(message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Could not write to log file: {e.Message}");
                throw;
            }
        }
    }
}