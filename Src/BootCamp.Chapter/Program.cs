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
            string cleanFile = $@"Balances{Guid.NewGuid()}.clean";
            string dirtyFile = @"Input/Balances.corrupted";
            Checks.Clean(dirtyFile, cleanFile);
        }
    }
}
