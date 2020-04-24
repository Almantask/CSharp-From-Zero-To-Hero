using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CleanCorruptedFile();
            DisplayTextTable();
            ShowPeopleBalances(PeoplesBalances.Balances());

            var file = File.ReadAllLines(@"Input\Balances.txt");
            var peopleAndBalances = PeoplesBalances.CreatePeopleDatabase(file);
            ShowPeopleBalances(peopleAndBalances);
        }

        private static void ShowPeopleBalances(Person[] peopleAndBalances)
        {
            var highestBalanceEver = BalanceStats.FindHighestBalanceEver(peopleAndBalances);
            var personWithBiggestLoss = BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances);
            var richestPerson = BalanceStats.FindRichestPerson(peopleAndBalances);
            var mostPoorPerson = BalanceStats.FindMostPoorPerson(peopleAndBalances);

            Console.WriteLine(TextTable.Build(highestBalanceEver, 3));
            Console.WriteLine(TextTable.Build(personWithBiggestLoss, 3));
            Console.WriteLine(TextTable.Build(richestPerson, 3));
            Console.WriteLine(TextTable.Build(mostPoorPerson, 3));

            Console.WriteLine("=========================================================================");
        }

        private static void DisplayTextTable()
        {
            var table = TextTable.Build($"Hello{Environment.NewLine}World!!", 5);
            Console.WriteLine(table);
        }

        private static void CleanCorruptedFile()
        {
            const string inFile = @"Input\Balances.corrupted";
            const string outFile = @"Input\Balances.txt";
            FileCleaner.Clean(inFile, outFile);
        }
    }
}