using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Problematic;

namespace BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware
{
    public class FileWriter : IWriter
    {
        private readonly string _file;
        public FileWriter(string file)
        {
            _file = file;
        }
        public void Write(string message)
        {
            File.WriteAllText(_file, message);
        }
    }
}
