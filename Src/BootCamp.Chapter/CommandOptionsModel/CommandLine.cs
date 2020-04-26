using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class CommandLine
    {
        public string InputFile { get; set; }
        public List<string> Options { get; set; }
        public string OutputFile { get; set; }
    }
}