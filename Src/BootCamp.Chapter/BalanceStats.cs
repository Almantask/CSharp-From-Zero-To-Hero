using System;
using System.Collections.Generic;
using System.Globalization;
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
            var highNames = new List<string>();
            int highBal = 0;

            foreach (var str in peopleAndBalances)
            {
                var arr = str.Split(", ");
                var name = arr[0];
                int balance = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    var ok = int.TryParse(arr[i], out int number);
                    if (ok)
                        balance = Math.Max(balance, number);
                }
                if (balance > highBal)
                {
                    highNames.Clear();
                    highNames.Add(name);
                    highBal = balance;
                }
                else if (balance == highBal)
                {
                    highNames.Add(name);
                }
            }

            var sb = new StringBuilder();
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var format = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            format.CurrencyGroupSeparator = string.Empty;
            for (int i = 0; i < highNames.Count; i++)
            {
                if (highNames.Count == 1)
                    sb.Append(highNames[i]);
                else if (i == highNames.Count - 1)
                {
                    sb.Append("and ");
                    sb.Append(highNames[i]);
                }
                else
                {
                    sb.Append(highNames[i]);
                    sb.Append(", ");
                }
            }
            sb.Append($" had the most money ever. {highBal:C0}.");

            return sb.ToString();
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
    }
}
