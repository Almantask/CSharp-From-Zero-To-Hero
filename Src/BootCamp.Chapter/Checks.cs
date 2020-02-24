using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        private const string currency = "\u00A4";
        private const char divider = ',';
        private static readonly CultureInfo cultureInfo = new CultureInfo("en-GB");

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats(peopleAndBalances, currency);

            return balanceStats.FindMostPoorPerson();
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats(peopleAndBalances, currency);

            return balanceStats.FindRichestPerson();
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats(peopleAndBalances, currency);

            return balanceStats.FindPersonWithBiggestLoss();
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            BalanceStats balanceStats = new BalanceStats(peopleAndBalances, currency);

            return balanceStats.FindHighestBalanceEver();
        }

        public static string Build(string message, in int padding)
        {
            TextTable textTable = new TextTable(message, padding);

            return textTable.Build();
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner fileCleaner = new FileCleaner(file, outputFile, cultureInfo, divider);
            fileCleaner.Clean();
        }
    }
}