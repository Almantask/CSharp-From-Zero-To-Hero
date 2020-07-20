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
            var dirtyFile = @"Input\Balances.corrupted";
            var cleanFile = @"Input\Balances.fixed";
            FileCleaner.Clean(dirtyFile, cleanFile);

            var peopleBalances = new StringBuilder();
            peopleBalances.Append(File.ReadAllText(cleanFile));


            string highestEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(cleanFile), 3);
            System.Console.WriteLine(highestEver);

            string biggestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(cleanFile), 3);
            System.Console.WriteLine(biggestLoss);

            string richest = TextTable.Build(BalanceStats.FindRichestPerson(cleanFile), 3);
            System.Console.WriteLine(richest);

            string poorest = TextTable.Build(BalanceStats.FindMostPoorPerson(cleanFile), 3);
            System.Console.WriteLine(poorest);
        }
    }
}
