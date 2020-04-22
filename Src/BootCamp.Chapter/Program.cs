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
        private const string CorruptedFilePath = @"..\..\..\Input\Balances.corrupted";
        private const string FixedFilePath = @"..\..\..\Input\Balances.fixed";
        private const int padding = 3;

        static void Main(string[] args)
        {
            var cleanLines = File.ReadAllLines(FixedFilePath);

        }
    }
}
