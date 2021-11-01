using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Logger : ILogBase
    {
        private string CurrentDirectory { get; set; }

        private string FileName { get; set; }

        private string FilePath { get; set; }

        public Logger()
        {
            this.CurrentDirectory = Directory.GetCurrentDirectory();
            this.FileName = "Log.txt";
            this.FilePath = this.CurrentDirectory + @"/" + this.FileName;
        }

        public void Log(string message)
        {
            using (StreamWriter sw = System.IO.File.AppendText(this.FilePath))
            {
                sw.Write("\r\nLog entry : ");
                sw.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                sw.WriteLine(" : {0}", message);
                sw.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}