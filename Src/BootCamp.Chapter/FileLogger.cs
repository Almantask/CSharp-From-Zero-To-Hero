using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class FileLogger : ILogger
    {
        public void Log(string text)
        {
            DateTime localDate = DateTime.Now;
            string path = @"C:\Users\Rabanian\Desktop\C# Bootcamp\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logs.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(localDate.ToLongTimeString() + "   " + text);
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(localDate.ToLongTimeString() + "   " + text);
                }
            }
        }
    }
}
