using System;
using System.Collections.Generic;
using System.Globalization;
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


            List<string> names = new List<string>();
            decimal maxNum = 0;


            foreach (string person in peopleAndBalances)
            {
                var items = GetCleanData(person);
                var currentName = items[0];
                decimal currentMax = 0;

                for (int j = 1; j < items.Length; j++)
                {
                    var isParse = decimal.TryParse(items[j], out decimal item);
                    if (isParse && item > currentMax)
                    {
                        currentMax = item;
                    }
                }


                if (currentMax >= maxNum)
                {
                    if (currentMax > maxNum)
                    {
                        maxNum = currentMax;
                        names.Clear();
                        names.Add(currentName);
                    }
                    else
                    {
                        names.Add(currentName);
                    }
                }
            }
            
            string nameInput = GetDisplayName(names);
            return $"{nameInput} had the most money ever. ¤{maxNum}.";
        }

        

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0)
                return "N/A.";
            
            List<string> names = new List<string>();
            decimal mostLoss = decimal.Zero;

            foreach (var person in peopleAndBalances)
            {
                var items = GetCleanData(person);

                if (items.Length <= 2)
                {
                    return "N/A.";
                }

                var currentName = items[0];
                var currentLoss = decimal.Zero;

                for (int j = 1; j < items.Length - 1; j++)
                {
                    var currentBalanceParse = decimal.TryParse(items[j], out decimal currentBalance);
                    var nextBalanceParse = decimal.TryParse(items[j + 1], out decimal nextBalance);

                    if (currentBalanceParse && nextBalanceParse && currentBalance - nextBalance > currentLoss)
                    {
                        currentLoss = currentBalance - nextBalance;
                    }
                }


                if (currentLoss >= mostLoss)
                {
                    if (currentLoss > mostLoss)
                    {
                        mostLoss = currentLoss;
                        names.Clear();
                        names.Add(currentName);
                    }
                    else
                    {
                        names.Add(currentName);
                    }
                }
            }


            string nameInput = GetDisplayName(names);
            return $"{nameInput} lost the most money. -¤{Math.Abs(mostLoss)}.";
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

            List<string> names = new List<string>();
            var max = decimal.Zero;

            foreach (var person in peopleAndBalances)
            {
                var items = GetCleanData(person);
                if (items.Length < 2)
                {
                    return "N/A.";
                }

                var currentName = items[0];

                var isParse = decimal.TryParse(items[items.Length-1], out decimal item);
                if (isParse && item >= max)
                {
                    if (item > max)
                    {
                        max = item;
                        names.Clear();
                        names.Add(currentName);
                    }
                    else
                    {
                        names.Add(currentName);
                    }
                }
            }

            string nameInput = GetDisplayName(names);
            if (!nameInput.Contains("and"))
            {
                return $"{nameInput} is the richest person. ¤{max}.";
            }
            return $"{nameInput} are the richest people. ¤{max}.";
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

            List<string> names = new List<string>();
            var min = decimal.MaxValue;

            foreach (var person in peopleAndBalances)
            {
                var items = GetCleanData(person);
                if (items.Length < 2)
                {
                    return "N/A.";
                }

                var currentName = items[0];

                var isParse = decimal.TryParse(items[items.Length - 1], out decimal item);
                if (isParse && item <= min)
                {
                    if (item < min)
                    {
                        min = item;
                        names.Clear();
                        names.Add(currentName);
                    }
                    else
                    {
                        names.Add(currentName);
                    }
                }
            }

            string nameInput = GetDisplayName(names);
            string finalPart = (min < decimal.Zero) ? $"-¤{Math.Abs(min)}" : $"¤{Math.Abs(min)}";

            if (!nameInput.Contains("and"))
            {
                return $"{nameInput} has the least money. {finalPart}.";
            }
            return $"{nameInput} have the least money. {finalPart}.";
        }

        public static string[] GetCleanData(string inputValue) => inputValue.Split(',').Select(a => a.Trim()).ToArray();

        private static string GetDisplayName(List<string> names)
        {
            var nameInput = new StringBuilder();

            if (names.Count > 2)
            {
                for (int k = 0; k < names.Count - 2; k++)
                {
                    nameInput.Append($"{names[k]}, ");
                }

                nameInput.Append($"{names[^2]} and ");
                nameInput.Append($"{names.Last()}");
            }
            else if (names.Count == 2)
            {
                nameInput.Append($"{names[0]} and {names[1]}");
            }
            else
            {
                nameInput.Append(names[0]);
            }

            return nameInput.ToString();
        }
    }
}
