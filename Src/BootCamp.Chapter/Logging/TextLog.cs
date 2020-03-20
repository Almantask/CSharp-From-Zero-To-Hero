using System;
using System.IO;

namespace BootCamp.Chapter.Logging
{
    class TextLog : ILog
    {

        public string GetConnection()
        {
            return @"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logging\Log.txt";
        }
        public void LogNow(string text)
        {
            File.AppendAllText(GetConnection(), $"{DateTime.Now}: {text}" + "\r\n");
        }
        public string Type()
        {
            return "Text";
        }
    }

}
