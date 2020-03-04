using System;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return BalanceStats.FindMostPoorPerson(TransformToPersonType(peopleAndBalances));
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return BalanceStats.FindRichestPerson(TransformToPersonType(peopleAndBalances));
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return BalanceStats.FindPersonWithBiggestLoss(TransformToPersonType(peopleAndBalances));
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            return BalanceStats.FindHighestBalanceEver(TransformToPersonType(peopleAndBalances));
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }

        private static Person[] TransformToPersonType(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return null;
            }

            var people = new Person[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var splitBalances = peopleAndBalances[i].Split(",");

                var person = new Person();
                person.SetName(splitBalances[0]);

                var balances = new decimal[splitBalances.Length - 1];
                for (int j = 0; j < splitBalances.Length - 1; j++)
                {
                    balances[j] = Convert.ToDecimal(splitBalances[j + 1]);
                }

                person.SetBalances(balances);
                people[i] = person;
            }

            return people;
        }

        private static bool IsArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }

            return false;
        }
    }
}
