﻿using System;
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

            int highestBalance = 0;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                // Splitting the values
                var array = values.Split(", ");
                int currentTopBalance = 0;

                // Loop around the array & parse the numbers
                for (int i = 1; i < array.Length; i++)
                {
                    bool succes = int.TryParse(array[i], out int parsed);

                    // find the highest number of current person
                    if (succes && parsed > currentTopBalance)
                    {
                        currentTopBalance = parsed;
                    }
                }

                // Check if the new number is higher/equal than the current highest balance and add the name to a List
                if (currentTopBalance > highestBalance)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    highestBalance = currentTopBalance;
                }
                else if (currentTopBalance == highestBalance)
                {
                    listOfPeople.Add(array[0]);
                }
            }

            // Get the list of people
            string persons = CountPeople(listOfPeople);
            return $"{persons} had the most money ever. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        { 
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            CultureInfo.CurrentCulture = new CultureInfo("en-US"); // because numbers are with . instead of ,
            List<String> listOfPeople = new List<String>();
            double biggestLoser = 0;

            foreach (var values in peopleAndBalances)
            {
                double currentTopLoss = 0;
                var array = values.Split(", ");

                // if the current person doesn't have at least 3 balances
                if (array.Length <= 2) return "N/A.";

                // Check what the biggest loss if for each person between current & next balance
                for (int i = 1; i < array.Length - 1; i++)
                {
                    bool succes = double.TryParse(array[i], out double currentBalance);
                    bool succes2 = double.TryParse(array[i+1], out double NextBalance);

                    if (succes && succes2 && currentBalance - NextBalance > currentTopLoss)
                    {
                        currentTopLoss = currentBalance - NextBalance;
                    }
                }

                // Check whom are the ones with the biggest loss & add them to a list
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

            int currentTopBalance = 0;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
                var array = values.Split(", ");

                // Parse the last value of each person
                bool succes = int.TryParse(array[^1], out int parsed);

                if (succes && parsed > currentTopBalance)
                {
                    listOfPeople.Clear();
                    listOfPeople.Add(array[0]);
                    currentTopBalance = parsed;
                }
                else if (succes && parsed == currentTopBalance)
                {
                    listOfPeople.Add(array[0]);
                }
            }
            // Get the list of people
            string persons = CountPeople(listOfPeople);
            if (listOfPeople.Count == 1)
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

            int currentHigh = 99999;
            List<String> listOfPeople = new List<String>();

            foreach (var values in peopleAndBalances)
            {
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

            // Get a negative amount back with the sign after the minus sign
            string amount = "";
            if (currentHigh < 0) amount = $"-¤{-currentHigh}";
            else amount = $"¤{currentHigh}";


            if (listOfPeople.Count == 1)
            {
                return $"{persons} has the least money. {amount}.";
            }
            return $"{persons} have the least money. {amount}.";
        }

        // Return the name of the people
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
