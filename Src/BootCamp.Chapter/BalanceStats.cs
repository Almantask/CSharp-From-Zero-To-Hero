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
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                return "N/A.";

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            StringBuilder peopleString = new StringBuilder();

            var biggestBalanceEver = float.MinValue;
            var personWithABiggestBalanceEver = "";
            string[] personWithABiggestBalanceEverArray = { };
            string message = "";

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (balance > biggestBalanceEver)
                    {
                        names.Clear();
                        biggestBalanceEver = balance;
                        personWithABiggestBalanceEver = personBalances.Key;
                        names.Add(personWithABiggestBalanceEver);
                    }
                    else if (balance == biggestBalanceEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                if (i == 0)
                {
                    peopleString.Append(names[i]);
                    continue;
                }
                if (i == names.Count - 1)
                {
                    peopleString.Append(" and ").Append(names[i]);
                    continue;
                }
                peopleString.Append(", ").Append(names[i]);
            }
            message = $"{peopleString} had the most money ever. ¤{biggestBalanceEver}.";

            return message;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                return "N/A.";

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            StringBuilder peopleString = new StringBuilder();
            var biggestLostEver = float.MaxValue;
            var personWithABiggestBalanceEver = "";
            string[] personWithABiggestLostEverArray = { };
            string message = "";

            foreach (var personBalances in peopleBalances)
            {
                for (int i = 0; i< personBalances.Value.Count-1; i++)
                {
                    var balanceDifferences = personBalances.Value[i] - personBalances.Value[i + 1];
                    if (balanceDifferences< biggestLostEver)
                    {
                        names.Clear();
                        biggestLostEver = balanceDifferences;
                        names.Add(personBalances.Key);
                        continue;
                    }
                    if (balanceDifferences==biggestLostEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }


        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                return "N/A.";

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            StringBuilder peopleString = new StringBuilder();
            var biggestLostEver = float.MinValue;
            var personWithABiggestBalanceEver = "";
            string[] personWithABiggestLostEverArray = { };
            string message = "";

            foreach (var personBalances in peopleBalances)
            {
                {
                    if (personBalances.Value.Last() > biggestLostEver)
                    {
                        names.Clear();
                        biggestLostEver = personBalances.Value.Last();
                        personWithABiggestBalanceEver = personBalances.Key;
                        names.Add(personWithABiggestBalanceEver);
                    }
                    else if (personBalances.Value.Last() == biggestLostEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                if (i == 0)
                {
                    peopleString.Append(names[i]);
                    continue;
                }
                if (i == names.Count - 1)
                {
                    peopleString.Append(" and ").Append(names[i]);
                    continue;
                }
                peopleString.Append(", ").Append(names[i]);
            }
            if (names.Count > 1)
            {
                message = $"{peopleString} are the richest people. ¤{biggestLostEver}.";
            }
            else
            {
                message = $"{peopleString} is the richest person. ¤{biggestLostEver}.";
            }

            return message;
        }
           

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                return "N/A.";

            Dictionary<string, List<float>> peopleBalances = ArrayOfPeople(peopleAndBalances);
            List<string> names = new List<string>();
            StringBuilder peopleString = new StringBuilder();
            StringBuilder lost = new StringBuilder();
            var biggestLostEver = float.MaxValue;
            var personWithABiggestBalanceEver = "";
            string[] personWithABiggestLostEverArray = { };
            string message = "";

            foreach (var personBalances in peopleBalances)
            {
                foreach (var balance in personBalances.Value)
                {
                    if (balance < biggestLostEver)
                    {
                        names.Clear();
                        biggestLostEver = balance;
                        personWithABiggestBalanceEver = personBalances.Key;
                        names.Add(personWithABiggestBalanceEver);
                    }
                    else if (balance == biggestLostEver)
                    {
                        names.Add(personBalances.Key);
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
                if (i == 0)
                {
                    peopleString.Append(names[i]);
                    continue;
                }
                if (i == names.Count - 1)
                {
                    peopleString.Append(" and ").Append(names[i]);
                    continue;
                }
                peopleString.Append(", ").Append(names[i]);
            }
            if (names.Count > 1 && biggestLostEver>=0)
            {
                message = $"{peopleString} have the least money. ¤{biggestLostEver}.";
            }
            else if (names.Count == 1 && biggestLostEver >= 0)
            {
                message = $"{peopleString} has the least money. ¤{biggestLostEver}.";
            }
            else if (names.Count > 1 && biggestLostEver < 0)
            {
                lost.Append(biggestLostEver).Replace("-", "");
                message = $"{peopleString} have the least money. -¤{lost}.";
            }
            else if (names.Count == 1 && biggestLostEver < 0)
            {
                lost.Append(biggestLostEver).Replace("-", "");
                message = $"{peopleString} has the least money. -¤{lost}.";
            }

            return message;

        }


        public static Dictionary<string, List<float>> ArrayOfPeople(string[] peopleAndBalances)
        {
            string[] splitString = { };

            Dictionary<string, List<float>> people = new Dictionary<string, List<float>>();

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {

                splitString = peopleAndBalances[i].Split(",");
                var name = splitString[0];
                people.Add(name, new List<float>());

                for (int j = 1; j < splitString.Length; j++)
                {
                    float balances;
                    var isNumber = float.TryParse(splitString[j], out balances);
                    if (isNumber)
                    {
                        people[name].Add(balances);
                    }
                }
                // Console.WriteLine("Name: " + name);

                foreach (var balance in people[name])
                {
                    // Console.WriteLine("balance: " + balance);
                }

            }
            return people;
        }





    }
}
