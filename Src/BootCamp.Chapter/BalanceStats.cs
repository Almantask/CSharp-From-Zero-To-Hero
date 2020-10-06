using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        const string defaultReturn = "N/A.";

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances != null && peopleAndBalances.Length != 0)
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

                StringBuilder sb = new StringBuilder();
                var highBalStr = FormatValue(highBal);

                BuildNamesString(sb, highNames);
                sb.Append($" had the most money ever. {highBalStr}.");

                return sb.ToString();
            }
            return defaultReturn;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (peopleAndBalances != null && peopleAndBalances.Length != 0)
            {
                var lowNames = new List<string>();
                int biggestLoss = 0;

                foreach (var str in peopleAndBalances)
                {
                    var arr = str.Split(", ");
                    var name = arr[0];
                    int balance = 0;
                    int difference = 0;
                    for (int i = 1; i < arr.Length; i++)
                    {
                        var ok = int.TryParse(arr[i], out int number);
                        if (ok)
                        {
                            balance = Math.Max(balance, number);
                            difference = balance - number;
                        }
                    }
                    if (difference > biggestLoss)
                    {
                        lowNames.Clear();
                        lowNames.Add(name);
                        biggestLoss = difference;
                    }
                    else if (difference == biggestLoss)
                    {
                        lowNames.Add(name);
                    }
                }

                if (biggestLoss == 0) return defaultReturn;

                var sb = new StringBuilder();

                var biggestLossStr = FormatValue(biggestLoss);

                BuildNamesString(sb, lowNames);
                sb.Append($" lost the most money. -{biggestLossStr}.");

                return sb.ToString();
            }
            return defaultReturn;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances != null && peopleAndBalances.Length != 0)
            {
                var richNames = new List<string>();
                int biggestBalance = 0;

                foreach (var str in peopleAndBalances)
                {
                    var arr = str.Split(", ");
                    var name = arr[0];

                    var ok = int.TryParse(arr[arr.Length-1], out int number);

                    if (ok)
                    {
                        if (number > biggestBalance)
                        {
                            richNames.Clear();
                            richNames.Add(name);
                            biggestBalance = number;
                        }
                        else if (number == biggestBalance)
                        {
                            richNames.Add(name);
                        }
                    }
                }

                var sb = new StringBuilder();

                var biggestBalanceStr = FormatValue(biggestBalance);

                BuildNamesString(sb, richNames);
                var pluralOrSingle = (richNames.Count == 1 ? "is the richest person." : "are the richest people.");
                sb.Append($" {pluralOrSingle} {biggestBalanceStr}.");

                return sb.ToString();
            }
            return defaultReturn;
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (peopleAndBalances != null && peopleAndBalances.Length != 0)
            {
                var poorNames = new List<string>();
                int lowestBalance = int.MaxValue;

                foreach (var str in peopleAndBalances)
                {
                    var arr = str.Split(", ");
                    var name = arr[0];

                    var ok = int.TryParse(arr[arr.Length - 1], out int number);

                    if (ok)
                    {
                        if (number < lowestBalance)
                        {
                            poorNames.Clear();
                            poorNames.Add(name);
                            lowestBalance = number;
                        }
                        else if (number == lowestBalance)
                        {
                            poorNames.Add(name);
                        }
                    }
                }

                var sb = new StringBuilder();

                var lowestBalanceStr = FormatValue(lowestBalance);

                BuildNamesString(sb, poorNames);
                var pluralOrSingle = (poorNames.Count == 1 ? "has" : "have");
                sb.Append($" {pluralOrSingle} the least money. {lowestBalanceStr}.");

                return sb.ToString();
            }
            return defaultReturn;
        }

        public static string FormatValue(int value)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var format = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            format.CurrencyGroupSeparator = string.Empty;
            format.CurrencyNegativePattern = 1;
            var valueStr = string.Format(format, "{0:C0}", value);

            return valueStr;
        }

        public static void BuildNamesString(StringBuilder sb, List<string> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names.Count == 1)
                    sb.Append(names[i]);
                else if (i == names.Count - 1)
                {
                    sb.Append("and ");
                    sb.Append(names[i]);
                }
                else if (i == names.Count - 2)
                {
                    sb.Append(names[i]);
                    sb.Append(" ");
                }
                else
                {
                    sb.Append(names[i]);
                    sb.Append(", ");
                }
            }
        }
    }
}
