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
            return Program.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return Program.FindRichestPerson(peopleAndBalances);
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return Program.FindPersonWithBiggestLoss(peopleAndBalances);
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            return Program.FindHighestBalanceEver(peopleAndBalances);
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message,padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }
    }
}
