using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats();
            return balanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats();
            return balanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats();
            return balanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats();
            return balanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string Build(string message, in int padding)
        {
            TextTable textTable = new TextTable();
            return textTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner fileCleaner = new FileCleaner();
            fileCleaner.Clean(file, outputFile);
        }
    }
}
