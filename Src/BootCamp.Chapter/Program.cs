using BootCamp.Chapter.ReportsManagers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.ASCII;
            ArgsReader.Read(args);
        }
    }
}