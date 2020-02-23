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
            return "";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);
            return balanceStats.FindHighestBalanceEver();
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
        }

        public static bool IsArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }
    }
}
