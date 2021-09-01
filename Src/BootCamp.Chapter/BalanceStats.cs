using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            decimal highestBalance = 0;
            List<String> people = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                // Splitting the values
                var array = values.Split(',').Select(a => a.Trim()).ToArray();

                decimal currentTopBalance = 0;

                // Loop around the array & parse the numbers
                for (int i = 1; i < array.Length; i++)
                {
                    bool parsedAmount = decimal.TryParse(array[i], out decimal parsed);

                    // find the highest number of current person
                    if (parsedAmount && parsed > currentTopBalance)
                    {
                        currentTopBalance = parsed;
                    }
                }

                // Check if the new number is higher/equal than the current highest balance and add the name to a List
                if (currentTopBalance > highestBalance)
                {
                    people.Clear();
                    people.Add(array[0]);
                    highestBalance = currentTopBalance;
                }
                else if (currentTopBalance == highestBalance)
                {
                    people.Add(array[0]);
                }
            }

            // Get the list of people
            string persons = ReturnPeople(people);
            return $"{persons} had the most money ever. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        { 
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            CultureInfo.CurrentCulture = new CultureInfo("en-US"); // because numbers are with . instead of ,
            List<String> people = new List<String>();
            decimal biggestLoser = 0;

            foreach (var values in peopleAndBalances)
            {
                decimal currentTopLoss = 0;
                var array = values.Split(',').Select(a => a.Trim()).ToArray();

                // if the current person doesn't have at least 3 balances
                if (array.Length <= 2) return "N/A.";

                // Check what the biggest loss if for each person between current & next balance
                for (int i = 1; i < array.Length - 1; i++)
                {
                    bool currentParseBalance = decimal.TryParse(array[i], out decimal currentBalance);
                    bool nextParseBalance = decimal.TryParse(array[i+1], out decimal NextBalance);

                    if (currentParseBalance && nextParseBalance && currentBalance - NextBalance > currentTopLoss)
                    {
                        currentTopLoss = currentBalance - NextBalance;
                    }
                }

                // Check whom are the ones with the biggest loss & add them to a list
                if (currentTopLoss > biggestLoser)
                {
                    people.Clear();
                    people.Add(array[0]);
                    biggestLoser = currentTopLoss;
                }
                else if (currentTopLoss == biggestLoser)
                {
                    people.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = ReturnPeople(people);
            if (people.Count == 1)
            {
                return $"{persons} lost the most money. -¤{biggestLoser}.";
            }
            return $"{persons} lost the most money. -¤{biggestLoser}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            decimal currentTopBalance = 0;
            List<String> people = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                var array = values.Split(',').Select(a => a.Trim()).ToArray();

                // Parse the last value of each person
                bool parsedAmount = decimal.TryParse(array[^1], out decimal parsed);

                if (parsedAmount && parsed > currentTopBalance)
                {
                    people.Clear();
                    people.Add(array[0]);
                    currentTopBalance = parsed;
                }
                else if (parsedAmount && parsed == currentTopBalance)
                {
                    people.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = ReturnPeople(people);
            if (people.Count == 1)
            {
                return $"{persons} is the richest person. ¤{currentTopBalance}.";
            }
            return $"{persons} are the richest people. ¤{currentTopBalance}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            decimal currentHigh = 99999;
            List<String> people = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                var array = values.Split(',').Select(a => a.Trim()).ToArray();
                bool parsedAmount = decimal.TryParse(array[^1], out decimal parsed);

                if (parsedAmount && parsed < currentHigh)
                {
                    people.Clear();
                    people.Add(array[0]);
                    currentHigh = parsed;
                }
                else if (parsedAmount && parsed == currentHigh)
                {
                    people.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = ReturnPeople(people);

            // Get a negative amount back with the sign after the minus sign
            string amount = "";

            if (currentHigh < 0)
            {
                amount = $"-¤{-currentHigh}";
            }
            else
            {
                amount = $"¤{currentHigh}";
            }


            if (people.Count == 1)
            {
                return $"{persons} has the least money. {amount}.";
            }
            return $"{persons} have the least money. {amount}.";
        }

        // Return the name of the people
        public static string ReturnPeople(List<string> people)
        {
            if (people.Count == 1)
            {
                return $"{people[0]}";
            }
            else if (people.Count == 2)
            {
                return $"{people[0]}, {people[1]}";
            }
            else
            {
                return String.Join(", ", people.ToArray(), 0, people.Count - 2) + ", " + people[^2] + " and " + people.LastOrDefault();
            }
        }
    }
}
