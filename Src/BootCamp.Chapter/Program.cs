using System;
using System.Collections.Generic;
using System.IO;
using BootCamp.Chapter.CvsProcessors;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var commands = "".Split(new char[] {' '}, 2);

            if (args == null || args.Length != 3)
            {
                Console.WriteLine("Invalid format");
                Console.WriteLine("\"path/to/input\" \"command\" \"path/to/output\"");
                Environment.Exit(1);
            }
            
            ArgumentParser.Parse(args);
        }
    }
}
