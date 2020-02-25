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
        public static void Main(string[] args)
        {
            
            var pplAndBalances = new string[] {
            "Tom, 15.5, 200, 500, 600, 200, 500, 10000",
            "Katherine, 85, 0, -500, 0, 500, 10000, 1500.99,-2",
            "Bill, 99999, 44, 99970, 99900",
            "Catie, 0, 500, 990, 1300,10000,1"};

            var foo = new PersonAndBalance(pplAndBalances[2]);

            var file = "../netcoreapp3.0/Input/BalancesCharBalance.Invalid";
            var dirtyFile = "../netcoreapp3.0/Input/BalancesCharBalance.Invalid";

            var fc = new FileCleaner();
            fc.Clean(file, dirtyFile);

            File.ReadAllText(file);
            Console.WriteLine(File.ReadAllText(file));
        }
    }
}
