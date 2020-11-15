using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = TextTable.Build($"Hello{Environment.NewLine}World!", 1);
            string s1 = TextTable.Build($"Hello", 1);
            System.Console.Write(s1.Length);
        }
    }
}
