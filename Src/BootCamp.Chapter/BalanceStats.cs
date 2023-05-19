using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            List<string> names = new List<string>();
            double maxNum = 0;


            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var items = GetCleanData(peopleAndBalances, i);
                var currentName = items[0];
                double currentMax = 0;

                for (int j = 1; j<items.Length; j++)
                {
                    var isParse = double.TryParse(items[j], out double item);
                    if (isParse)
                    {
                        if (item > currentMax)
                        {
                            currentMax = item;
                        }
                    }
                }

                //THIS IS WHERE CURRENTMAX NUMBER & OWNER OF THAT NUMBER a

                if (currentMax >= maxNum)
                {
                    if (currentMax > maxNum)
                    {
                        maxNum = currentMax;
                        names.Clear();
                        names.Add(currentName);

                    }
                    else if (currentMax == maxNum)
                    {
                        names.Add(currentName);
                    }
                }

                
            }

            string final = string.Empty;
            if (names.Count > 2)
            {
                for (int k = 0; k < names.Count - 2; k++)
                {
                    final += $"{names[k]}, ";
                }

                final += $"{names[^2]} and ";
                final += $"{names.Last()}";
            }
            else if (names.Count == 2)
            {
                final += $"{names[0]} and {names[1]}";
            }
            else 
            { 
                final = names[0];
            }
            return $"{final} had the most money ever. ¤{maxNum}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
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

        public static string[] GetCleanData(string[] peopleAndBalances, int index)
        {
            var item = peopleAndBalances[index];
            return item.Split(", ");
        }
    }
}
