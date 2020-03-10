using System;
using System.IO;

namespace BootCamp.Chapter.Logging
{
    abstract class LogToText : ILog, IConnection
    {

        private string _Connection = @"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logging\Log.txt";
        public string GetConnection()
        {
            return _Connection;
        }

        public void LogOpenProgram()
        {
            LogNow($"Program Started. Time: {DateTime.Now}");
        }
        public void LogCloseProgram()
        {
            LogNow($"Program Stopped. Time: {DateTime.Now}");
        }
        public void LogCrash(Exception e)
        {
            LogNow($"Program Crashed Time: {DateTime.Now}\r\nReason: {e.Message}");
        }
        public void LogNow(string text)
        {
            using (var fileS = new FileStream(GetConnection(), FileMode.Create))
            {
                using (var writer = new StreamWriter(fileS))
                {
                    writer.WriteLine(text);
                }
            }


        }
    }

}
