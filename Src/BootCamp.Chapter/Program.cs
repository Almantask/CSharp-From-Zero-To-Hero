using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = new string[] {
                $"{AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug\netcoreapp3.0\",@"Input\Balances.corrupted")}",
                $"{AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug\netcoreapp3.0\",@"Input\Balances.clean" )}"
            };

            foreach (var file in files)
            {
                FileCleaner.Clean(file, $"{file}.cleaned");

                string[] cleanedContents = File.ReadAllLines($"{file}.cleaned");
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindHighestBalanceEver(cleanedContents)}", 3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindPersonWithBiggestLoss(cleanedContents)}", 3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindRichestPerson(cleanedContents)}", 3));
                Console.WriteLine(TextTable.Build($"{BalanceStats.FindMostPoorPerson(cleanedContents)}", 3));

                File.Delete($"{file}.cleaned");
            }
        }
    }
}
