using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace BootCamp.Chapter
{
    class FileLogger: ILog
    {
        int _number;
        public FileLogger(int num)
        {
            _number = num;
        }
        public void WriteMessage(string message)
        {
            string fileName = $"Log_{DateTime.Now.ToShortDateString().Replace("/", "")}_{_number}.txt";
            string file = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using StreamWriter sw = File.AppendText(file);
            sw.WriteLine(message);
            sw.WriteLine("----");
        }
    }
}
