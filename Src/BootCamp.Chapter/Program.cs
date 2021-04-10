using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program : ILogger
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.LogToFile("Again");
            p.LogToConsole("We logged to file.");
        }

        public void LogToConsole(string text)
        {
            Console.WriteLine(text);
        }

        public void LogToFile(string text)
        {
            string path = @"C:\Users\Rabanian\Desktop\C# Bootcamp\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logs.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(text);
                }
            }
            else
            {
                using(StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(text);
                }
            }
        }
    }
}
