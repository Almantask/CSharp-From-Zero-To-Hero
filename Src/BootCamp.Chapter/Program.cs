using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inFile = @"Input\Balances.corrupted";
            const string outFile = @"Input\Balances.txt";
            FileCleaner.Clean(inFile, outFile);

            var table = TextTable.Build($"Hello{Environment.NewLine}World!!", 5);
            Console.WriteLine(table);

            var highestBalanceEver = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            var personWithBiggestLoss = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            var richestPerson = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            var mostPoorPerson = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);

            Console.WriteLine(TextTable.Build(highestBalanceEver, 3));
            Console.WriteLine(TextTable.Build(personWithBiggestLoss, 3));
            Console.WriteLine(TextTable.Build(richestPerson, 3));
            Console.WriteLine(TextTable.Build(mostPoorPerson, 3));

            Console.WriteLine("=========================================================================");

            var openFile = File.ReadAllLines(outFile);

            var highestBalanceEver2 = BalanceStats.FindHighestBalanceEver(openFile);
            var personWithBiggestLoss2 = BalanceStats.FindPersonWithBiggestLoss(openFile);
            var richestPerson2 = BalanceStats.FindRichestPerson(openFile);
            var mostPoorPerson2 = BalanceStats.FindMostPoorPerson(openFile);

            Console.WriteLine(TextTable.Build(highestBalanceEver2, 3));
            Console.WriteLine(TextTable.Build(personWithBiggestLoss2, 3));
            Console.WriteLine(TextTable.Build(richestPerson2, 3));
            Console.WriteLine(TextTable.Build(mostPoorPerson2, 3));

        }
    }
}