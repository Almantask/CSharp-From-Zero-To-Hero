using System;
using System.IO;

namespace BootCamp.Chapter.Logger
{
    public class FileLogger : ILogger
    {
        private string _filePath = @"E:\repos\CsInnBootcampHomework\podejście 2\Src\BootCamp.Chapter\logger.txt";


        public void LogMessage(string message)
        {
            File.AppendAllText(_filePath, $"{DateTime.Now} {message}");
        }
    }
}
