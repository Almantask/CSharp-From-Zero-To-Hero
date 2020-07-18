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
        const string corruptedFile = @"Input\Balances.corrupted";


        static void Main(string[] args)
        {
            FileCleaner.Clean(corruptedFile, cleanedFile);

            var insideFile = File.ReadAllText(cleanedFile);
            var peopleAndBalances = insideFile.Split(Environment.NewLine);

            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(peopleAndBalances),3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(peopleAndBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(peopleAndBalances), 3));
        }
    }
}
