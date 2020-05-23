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
            decimal highestBalance = 0;

            foreach (Person person in GetPeople(peopleAndBalances))
            {
                if (person.Balance.Max() > highestBalance)
                {
                    highestBalance = person.Balance.Max();
                }
            }
            return highestBalance.ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            decimal biggestLoss = 0;
            string personWithBiggestLoss = null;
            foreach (Person person in GetPeople(peopleAndBalances))
            {
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
            return personWithBiggestLoss;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            return "";
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
    }
}
