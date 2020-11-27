using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace BootCamp.Chapter
{
    class Logger: ILog
    {
        int _number;
        public Logger(int num)
        {
            _number = num;
        }
        public void WriteMessageToFile(string message)
        {
            string fileName = $"Log_{DateTime.Now.ToShortDateString().Replace("/", "")}_{_number}.txt";
            string file = Path.Combine(Directory.GetCurrentDirectory(), fileName);

            using StreamWriter sw = File.AppendText(file);
            sw.WriteLine(message);
            sw.WriteLine("----");
        }
        public void WriteMessageToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
