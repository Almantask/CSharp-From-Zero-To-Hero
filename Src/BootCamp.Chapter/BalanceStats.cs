using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal highestBalance = 0;
            List<string> Name = new List<string>();

            foreach (Person person in GetPeople(peopleAndBalances))
            {
                if (person.Balance.Max() > highestBalance)
                {
                    highestBalance = person.Balance.Max();
                    Name.Clear();
                    Name.Add(person.Name);
                }
                else if (person.Balance.Max() == highestBalance)
                {
                    Name.Add(person.Name);
                }
            }

            return $"{FormatName(Name)} had the most money ever. ¤{highestBalance.ToString()}.";
        }

        

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal biggestLoss = 0;
            string personWithBiggestLoss = null;
            bool enoughBalance = false;

            foreach (Person person in GetPeople(peopleAndBalances))
            {
                if (person.Balance.Count > 1)
                {
                    enoughBalance = true;
                }

                for (int i = 1; i < person.Balance.Count; i++)
                {
                    decimal currentLoss = person.Balance[i - 1] - person.Balance[i];
                    if (currentLoss > biggestLoss)
                    {
                        biggestLoss = currentLoss;
                        personWithBiggestLoss = person.Name;
                    }
                }
            }

            if (!enoughBalance)
                return "N/A.";

            return $"{personWithBiggestLoss} lost the most money. -¤{Math.Abs(biggestLoss)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            decimal highestBalance = 0;
            List<string> RichestPerson = new List<string>();

            foreach (Person person in GetPeople(peopleAndBalances))
            {
                if (person.Balance[^1] > highestBalance)
                {
                    highestBalance = person.Balance[^1];
                    RichestPerson.Clear();

                    RichestPerson.Add(person.Name);
                }
                else if (person.Balance[^1] == highestBalance)
                {
                    RichestPerson.Add(person.Name);
                }
            }
            return $"{FormatName(RichestPerson)} {(RichestPerson.Count > 1 ? "are the richest people." : "is the richest person.")} ¤{highestBalance.ToString()}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (isArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";
            var ListOfPeople = GetPeople(peopleAndBalances);

            decimal lowerBalance = GetPeople(peopleAndBalances)[0].Balance[^1];
            List<string> mostPoorPerson = new List<string>();

            foreach (Person person in GetPeople(peopleAndBalances))
            {
                if (person.Balance[^1] < lowerBalance)
                {
                    lowerBalance = person.Balance[^1];
                    mostPoorPerson.Clear();
                    mostPoorPerson.Add(person.Name);
                }
                else if (person.Balance[^1] == lowerBalance)
                {
                    mostPoorPerson.Add(person.Name);
                }
            }
            return $"{FormatName(mostPoorPerson)} {(mostPoorPerson.Count > 1 ? "have the least money." : "has the least money.")} {(lowerBalance >= 0 ? null : "-")}¤{(Math.Abs(lowerBalance).ToString())}.";
        }

        public static List<Person> GetPeople(string[] peopleAndBalances)
        {
            List<Person> People = new List<Person>();
            foreach (string peopleAndBalance in peopleAndBalances)
            {
                var irregularArray = peopleAndBalance.Split(',');
                Person person = new Person();
                person.Name = irregularArray[0];
                for (int i = 1; i < irregularArray.Length; i++)
                {
                    decimal balance;
                    if (decimal.TryParse(irregularArray[i], NumberStyles.Any, new CultureInfo("en-US"), out balance))
                    {
                        person.Balance.Add(balance);
                    }
                }
                People.Add(person);
            }
            return People;
        }

        private static string FormatName(List<string> Name)
        {
            string formattedName = "";
            if (Name.Count == 1)
                return Name[0];

            for (int i = 0; i < Name.Count; i++)
            {
                formattedName += Name[i];
                if (Name.Count - 2 == i)
                {
                    formattedName += " and ";
                }
                else if (Name.Count - 2 > i)
                {
                    formattedName += ", ";
                }
            }

            return formattedName;
        }

        private static bool isArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }
    }
}
