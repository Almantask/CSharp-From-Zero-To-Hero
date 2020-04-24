using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] people)
        {
            var peopleAndBalances = PeoplesBalances.CreatePeopleDatabase(people);
            return BalanceStats.FindMostPoorPerson(peopleAndBalances);
        }

        public static string FindRichestPerson(string[] people)
        {
            var peopleAndBalances = PeoplesBalances.CreatePeopleDatabase(people);
            return BalanceStats.FindRichestPerson(peopleAndBalances);
        }

        public static string FindPersonWithBiggestLoss(string[] people)
        {
            var peopleAndBalances = PeoplesBalances.CreatePeopleDatabase(people);
            return BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances);
        }

        public static string FindHighestBalanceEver(string[] people)
        {
            var peopleAndBalances = PeoplesBalances.CreatePeopleDatabase(people);
            return BalanceStats.FindHighestBalanceEver(peopleAndBalances);
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }
    }
}
