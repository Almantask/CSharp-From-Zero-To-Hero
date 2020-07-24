using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            var people = CreatePeopleObjectFromArrayInput(peopleAndBalances);

            string poorestPerson = people.FindPoorestPerson();
            return poorestPerson;
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            var people = CreatePeopleObjectFromArrayInput(peopleAndBalances);

            string richestPerson = people.FindRichestPerson();
            return richestPerson;
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var people = CreatePeopleObjectFromArrayInput(peopleAndBalances);

            string biggestLoss = people.FindPersonWithBiggestLoss();
            return biggestLoss;
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            var people = CreatePeopleObjectFromArrayInput(peopleAndBalances);

            string highestEver = people.FindHighestBalanceEver();
            return highestEver;
        }

        public static string Build(string message, in int padding)
        {
            string builtTextTable = TextTables.Build(message, padding);
            return builtTextTable;
        }

        public static void Clean(string file, string outputFile)
        {
            var fileWithBalances = new FileWithBalances(file);
            string cleanedContent = fileWithBalances.GetContent();
            File.WriteAllText(outputFile, cleanedContent);
        }

        private static PeopleAndBalances CreatePeopleObjectFromArrayInput(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null) peopleAndBalances = new string[0];
            return new PeopleAndBalances(String.Join(Environment.NewLine, peopleAndBalances));
        }
    }
}
