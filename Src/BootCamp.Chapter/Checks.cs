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
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);
            return balanceStats.GetPoorestPersonAnswer();
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);
            return balanceStats.GetRichestPersonAnswer();
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);
            if (!balanceStats.isValidForCheck())
            {
                return "N/A.";
            }
            return balanceStats.GetPersonWithBiggestLossAnswer();
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var balanceStats = new PeopleAndBalanceManager(peopleAndBalances);
            return balanceStats.GetHighestBalanceEverAnswer();
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
