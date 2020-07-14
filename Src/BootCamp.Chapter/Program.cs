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
        const string cleanedFile = @"Input\Balances.clean";
        const string dirtyFile = @"Input\Balances.corrupted";
        static void Main(string[] args)
        {
            FileCleaner.Clean(dirtyFile, cleanedFile);

        }
    }
}
