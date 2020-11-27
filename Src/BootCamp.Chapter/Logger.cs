using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;
using System.IO;

namespace BootCamp.Chapter
{
    class Logger: ILog
    {       
        public void WriteMessage(string message)
        {
            string fileName = $"Log_{DateTime.Now.ToShortDateString().Replace("/", "")}_{DateTime.Now.ToLongTimeString().Replace(":","")}.txt";
            string file = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            ArrayList list = new ArrayList();
            list.Add(message);
            using StreamWriter sw = File.CreateText(file);
            for (int i = 0; i < list.Count; i++)
            {
                sw.WriteLine(list[i]);

            }
        }
    }
}
