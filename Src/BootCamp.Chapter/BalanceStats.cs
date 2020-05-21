using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            List<Person> people = DataToObject(peopleAndBalances);
            var highestBalance = people.Where(p => p.Balances.Contains(people.Max(b => b.Balances.Max()))).ToList();

            return $"{GenerateNameString(highestBalance)} had the most money ever. {ConvertBalanceToText(highestBalance.Max(b => b.Balances.Max()))}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            List<Person> people = DataToObject(peopleAndBalances);

            Single highestLoss = 0;
            foreach (var person in people)
            {
                var loss = person.Balances.Max() - person.Balances.LastOrDefault();
                if (loss > highestLoss * -1)
                {
                    highestLoss = loss * -1;
                }
            }

            if (highestLoss == 0)
                return "N/A.";

            List<Person> personHighLoss = people.Where(l => (l.Balances.Max() - l.Balances.LastOrDefault()) * -1 == highestLoss).ToList();

            return $"{GenerateNameString(personHighLoss)} lost the most money. {ConvertBalanceToText(highestLoss)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            List<Person> people = DataToObject(peopleAndBalances);
            var richestPerson = people.Where(p => p.Balances.LastOrDefault() == people.Max(x => x.Balances.LastOrDefault())).ToList();

            if (richestPerson.Count > 1)
                return $"{GenerateNameString(richestPerson)} are the richest people. {ConvertBalanceToText(richestPerson.FirstOrDefault().Balances.LastOrDefault())}.";
            else
                return $"{GenerateNameString(richestPerson)} is the richest person. {ConvertBalanceToText(richestPerson.FirstOrDefault().Balances.LastOrDefault())}.";


        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            List<Person> people = DataToObject(peopleAndBalances);
            var mostPoorPerson = people.Where(p => p.Balances.LastOrDefault() == people.Min(x => x.Balances.LastOrDefault())).ToList();

            if (mostPoorPerson.Count > 1)
                return $"{GenerateNameString(mostPoorPerson)} have the least money. {ConvertBalanceToText(mostPoorPerson.FirstOrDefault().Balances.LastOrDefault())}.";
            else
                return $"{GenerateNameString(mostPoorPerson)} has the least money. {ConvertBalanceToText(mostPoorPerson.FirstOrDefault().Balances.LastOrDefault())}.";
        }

        /// <summary>
        /// Convert string array to List of Person objects
        /// </summary>
        /// <param name="input">array of people and balances</param>
        /// <returns>List of Person objects</returns>
        public static List<Person> DataToObject(string[] input)
        {
            List<Person> people = new List<Person>();
            foreach (var line in input)
            {
                var personArray = line.Split(',').ToArray();
                List<Single> Balances = new List<Single>();
                Person person = new Person();
                person.Name = personArray[0];
                for (int i = 1; i < personArray.Count(); i++)
                {
                    if (Single.TryParse(personArray[i], out float floatValue))
                        Balances.Add(floatValue);
                }
                person.Balances = Balances;
                people.Add(person);
            }
            return people;
        }

        /// <summary>
        /// Generate formated list for output
        /// </summary>
        /// <param name="people">list of people</param>
        /// <returns>formated names-list</returns>
        public static string GenerateNameString(List<Person> people)
        {
            StringBuilder peopleString = new StringBuilder();
            var firstPerson = people.FirstOrDefault();
            var lastPerson = people.LastOrDefault();
            foreach (var person in people)
            {
                if (person != firstPerson && person != lastPerson)
                    peopleString.Append(", ");
                else if (person == lastPerson && people.Count > 1)
                    peopleString.Append(" and ");
                peopleString.Append(person.Name);
            }

            return peopleString.ToString();
        }

        /// <summary>
        /// Check if array is null or empty
        /// </summary>
        /// <param name="array">Array</param>
        /// <returns>is array null or empty</returns>
        public static bool IsArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Convert numeric value to "balance text"
        /// </summary>
        /// <param name="balance">numeric value</param>
        /// <returns>balance text</returns>
        public static string ConvertBalanceToText(Single balance)
        {
            if (balance < 0)
                return $"-¤{balance.ToString().Remove(0, 1)}";
            else
                return $"¤{balance}";
        }
    }
}
