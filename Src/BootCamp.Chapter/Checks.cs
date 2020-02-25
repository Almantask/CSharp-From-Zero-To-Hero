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
            var balanceStats = new BalanceStats();
            return balanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            var balanceStats = new BalanceStats();
            return balanceStats.FindRichestPerson(peopleAndBalances);
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var balanceStats = new BalanceStats();
            return balanceStats.FindPersonWithBiggestLoss(peopleAndBalances);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            var balanceStats = new BalanceStats();
            return balanceStats.FindHighestBalanceEver(peopleAndBalances);
        }

        public static string Build(string message, in int padding)
        {
            var textTable = new TextTable();
            return textTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            var cleanTable = new CleanTable(file, outputFile);
            cleanTable.Clean();
        }
    }
}
