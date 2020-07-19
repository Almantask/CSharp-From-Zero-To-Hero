using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestBalanceEver = float.MinValue;

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (balance > biggestBalanceEver)
                    {
                        names.Clear();
                        biggestBalanceEver = balance;
                        names.Add(personBalances.Key);
                    }
                    if (Math.Round((decimal)balance, 2) == (Math.Round((decimal)biggestBalanceEver, 2)))
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }
            return $"{BuildNamesString(names)} had the most money ever. ¤{biggestBalanceEver}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLostEver = float.MaxValue;

            foreach (var personBalances in peopleBalances)
            {
                for (int i = 0; i < personBalances.Value.Count - 1; i++)
                {
                    var balanceDifferences = personBalances.Value[i + 1] - personBalances.Value[i];
                    if (balanceDifferences < biggestLostEver)
                    {
                        names.Clear();
                        biggestLostEver = balanceDifferences;
                        names.Add(personBalances.Key);
                        continue;
                    }
                    if (Math.Round((decimal)balanceDifferences, 2) == (Math.Round((decimal)biggestLostEver, 2)))
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            if (names.Count == 0)
            {
                return "N/A.";
            }
            return $"{BuildNamesString(names)} lost the most money. {BuildCurrancy(biggestLostEver)}.";
        }
        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var biggestLastBalance = float.MinValue;

            foreach (var personBalances in peopleBalances)
            {
                {
                    if (personBalances.Value.Last() > biggestLastBalance)
                    {
                        names.Clear();
                        biggestLastBalance = personBalances.Value.Last();
                        names.Add(personBalances.Key);
                    }
                    else if (personBalances.Value.Last() == biggestLastBalance)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            string peopleString = BuildNamesString(names);
            if (names.Count > 1)
            {
                return $"{peopleString} are the richest people. {BuildCurrancy(biggestLastBalance)}.";
            }
            return $"{peopleString} is the richest person. {BuildCurrancy(biggestLastBalance)}.";
        }


        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
            {
                return "N/A.";
            }

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            var lowestBalanceEver = float.MaxValue;

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (personBalances.Value.Last() < lowestBalanceEver)
                    {
                        names.Clear();
                        lowestBalanceEver = balance;
                        names.Add(personBalances.Key);
                    }
                    else if (personBalances.Value.Last() == lowestBalanceEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            if (names.Count > 1)
            {
                return $"{BuildNamesString(names)} have the least money. {BuildCurrancy(lowestBalanceEver)}.";
            }

            return $"{BuildNamesString(names)} has the least money. {BuildCurrancy(lowestBalanceEver)}.";
        }


        public static Dictionary<string, List<float>> ArrayOfPeople(string[] peopleAndBalances)
        {
            Dictionary<string, List<float>> people = new Dictionary<string, List<float>>();


            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                string[] splitString = peopleAndBalances[i].Split(",");
                var name = splitString[0];
                if (!Regex.IsMatch(name, @"^[\p{L} '\-]+$"))
                {
                    throw new ArgumentException("Invalid name ");
                }
                if (splitString.Length > 1)
                {
                    people.Add(name, new List<float>());

                    for (int j = 1; j < splitString.Length; j++)
                    {
                        float balances;

                        var isNumber = float.TryParse(splitString[j].Replace("£", ""), out balances);

                        if (!isNumber)
                        {
                            throw new ArgumentException("Bad balance");

                        }

                        people[name].Add(balances);
                    }
                }
            }
            return people;

        }

        public static string BuildCurrancy(float currancy)
        {
            if (currancy < 0)
            {
                return $"-¤{Math.Abs(currancy)}";
            }
            return $"¤{currancy}";
        }

        public static string BuildNamesString(List<string> names)
        {
            var uniqeNames = names.Distinct().ToList();
            StringBuilder peopleString = new StringBuilder();
            for (int i = 0; i < uniqeNames.Count; i++)
            {
                if (i == 0)
                {
                    peopleString.Append(uniqeNames[i]);
                    continue;
                }
                if (i == uniqeNames.Count - 1)
                {
                    peopleString.Append(" and ").Append(uniqeNames[i]);
                    continue;
                }
                peopleString.Append(", ").Append(uniqeNames[i]);
            }
            return peopleString.ToString();
        }


    }
}
