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

            int j = 0;
            int currentMax = 0;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                // Splitting the values
                var array = values.Split(", ");
                int newNumber = 0;

                // Loop around to parse the numbers
                for (int i = 1; i < array.Length; i++)
                {
                    bool succes = int.TryParse(array[i], out int parsed);

                    // find the highest number of each person
                    if (succes && parsed > newNumber)
                    {
                        newNumber = parsed;
                    }
                }

                // Check if the current max number is higher than the last one or equal
                if (newNumber > currentMax)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    currentMax = newNumber;
                }
                else if (newNumber == currentMax)
                {
                    listOfPeople.Add(array[0]);
                }
                j++;
            }

            // Get the list of people
            string persons = CountPeople(listOfPeople);
            return $"{persons} had the most money ever. ¤{currentMax}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        { 
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";
            CultureInfo.CurrentCulture = new CultureInfo("en-US");

            List<String> listOfPeople = new List<String>();

            double biggestLoser = 0;

            foreach (var values in peopleAndBalances)
            {
                double currentTopLoss = 0;
                // Splitting the values
                var array = values.Split(", ");

                if (array.Length <= 2) return "N/A.";

                // Check the loss between current & next balance
                for (int i = 1; i < array.Length - 1; i++)
                {
                    bool succes = double.TryParse(array[i], out double currentBalance);
                    bool succes2 = double.TryParse(array[i+1], out double NextBalance);

                    if (succes && succes2)
                    {
                        if (currentBalance - NextBalance > currentTopLoss)
                        {
                            currentTopLoss = currentBalance - NextBalance;
                        }
                    }
                }

                // Check whom are the ones with the biggest loss
                if (currentTopLoss > biggestLoser)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    biggestLoser = currentTopLoss;
                }
                else if (currentTopLoss == biggestLoser)
                {
                    listOfPeople.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = CountPeople(listOfPeople);
            if (listOfPeople.Count == 1)
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

            int currentHigh = 0;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                // Splitting the values
                var array = values.Split(", ");

                bool succes = int.TryParse(array[^1], out int parsed);

                if (succes && parsed > currentHigh)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    currentHigh = parsed;
                }
                else if (succes && parsed == currentHigh)
                {
                    listOfPeople.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = CountPeople(listOfPeople);
            if (listOfPeople.Count == 1)
            {
                return $"{persons} is the richest person. ¤{currentHigh}.";
            }
            return $"{persons} are the richest people. ¤{currentHigh}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            int currentHigh = 99999;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                // Splitting the values
                var array = values.Split(", ");
                bool succes = int.TryParse(array[^1], out int parsed);

                if (succes && parsed < currentHigh)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    currentHigh = parsed;
                }
                else if (succes && parsed == currentHigh)
                {
                    listOfPeople.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = CountPeople(listOfPeople);

            string amount = "";
            if (currentHigh < 0) amount = $"-¤{-currentHigh}";
            else amount = $"¤{currentHigh}";

            if (listOfPeople.Count == 1)
            {
                return $"{persons} has the least money. {amount}.";
            }
            return $"{persons} have the least money. {amount}.";
        }


        public static string CountPeople(List<string> people)
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
                string listpeople = "";
                for (int i = 0; i < people.Count - 2; i++)
                {
                    listpeople += people[i] + ", ";
                }
                return $"{listpeople}{people[^2]} and {people[^1]}";
            }
        }
    }
}
