using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            Person[] persons = ParseBalances(peopleAndBalances);
            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? lastBalance;
            float? lowestLastBalance = null;
            string[] persosnsWithLeastMoney = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                lastBalance = persons[i].GetLastBalance();

                if (lowestLastBalance == null)
                {
                    lowestLastBalance = lastBalance;
                    persosnsWithLeastMoney = new string[] { name };
                }
                else if (lastBalance == lowestLastBalance)
                {
                    persosnsWithLeastMoney = AppendToStringArray(persosnsWithLeastMoney, name);
                }
                else if (lastBalance < lowestLastBalance)
                {
                    persosnsWithLeastMoney = new[] { name };
                    lowestLastBalance = lastBalance;
                }
            }

            if (lowestLastBalance == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            if (persosnsWithLeastMoney.Length == 1)
            {
                return $"{ComposeListString(persosnsWithLeastMoney)} has the least money. {lowestLastBalance:c0}.";
            }
            else
            {
                return $"{ComposeListString(persosnsWithLeastMoney)} have the least money. {lowestLastBalance:c0}.";
            }
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            Person[] persons = ParseBalances(peopleAndBalances);

            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? lastBalance;
            float? HighestLastBalance = null;
            string[] richestPersons = null;

            for (int i = 0; i < persons.Length; i++)
            {

                name = persons[i].GetName();
                lastBalance = persons[i].GetLastBalance();

                if (HighestLastBalance == null)
                {
                    HighestLastBalance = lastBalance;
                    richestPersons = new string[] { name };
                }
                else if (lastBalance == HighestLastBalance)
                {
                    richestPersons = AppendToStringArray(richestPersons, name);
                }
                else if (lastBalance > HighestLastBalance)
                {
                    richestPersons = new[] { name };
                    HighestLastBalance = lastBalance;
                }
            }

            if (HighestLastBalance == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            if (richestPersons.Length == 1)
            {
                return $"{ComposeListString(richestPersons)} is the richest person. {HighestLastBalance:c0}.";
            }
            else
            {
                return $"{ComposeListString(richestPersons)} are the richest people. {HighestLastBalance:c0}.";
            }

        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            Person[] persons = ParseBalances(peopleAndBalances);

            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? biggestPersonalLoss;
            float? biggestLoss = null;
            string[] persosnsWithBiggestLoss = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                biggestPersonalLoss = persons[i].GetBiggestLoss();

                if (biggestLoss == null)
                {
                    biggestLoss = biggestPersonalLoss;
                    persosnsWithBiggestLoss = new string[] { name };
                }
                else if (biggestPersonalLoss == biggestLoss)
                {
                    persosnsWithBiggestLoss = AppendToStringArray(persosnsWithBiggestLoss, name);
                }
                else if (biggestPersonalLoss < biggestLoss)
                {
                    persosnsWithBiggestLoss = new[] { name };
                    biggestLoss = biggestPersonalLoss;
                }
            }

            if (biggestLoss == null)
            {
                return "N/A.";
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            return $"{ComposeListString(persosnsWithBiggestLoss)} lost the most money. {biggestLoss:c0}.";
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            Person[] persons = ParseBalances(peopleAndBalances);

            if (persons == null || persons.Length == 0)
            {
                return "N/A.";
            }
            string name;
            float? highestPersonalBalance;
            float? highestBalance = null;
            string[] persosnsWithHighestBalance = null;

            for (int i = 0; i < persons.Length; i++)
            {
                name = persons[i].GetName();
                highestPersonalBalance = persons[i].GetHighestBalance();

                if (highestBalance == null)
                {
                    highestBalance = highestPersonalBalance;
                    persosnsWithHighestBalance = new string[] { name };
                }
                else if (highestPersonalBalance == highestBalance)
                {
                    persosnsWithHighestBalance = AppendToStringArray(persosnsWithHighestBalance, name);
                }
                else if (highestPersonalBalance > highestBalance)
                {
                    persosnsWithHighestBalance = new[] { name };
                    highestBalance = highestPersonalBalance;
                }
            }
            CultureInfo ci = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            ci.NumberFormat.CurrencyNegativePattern = 1;
            ci.NumberFormat.CurrencyGroupSeparator = "";
            CultureInfo.CurrentCulture = ci;
            return $"{ComposeListString(persosnsWithHighestBalance)} had the most money ever. {highestBalance:c0}.";
        }

        public static string Build(string message, in int padding)
        {
            return TextTable.Build(message, padding);
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner.Clean(file, outputFile);
        }

        public static Person[] ParseBalances(string[] lines)
        {
            if (lines == null || lines.Length == 0) return null;
            var persons = new Person[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] slots = lines[i].Split(",");
                string name = slots[0];
                float[] balances = null;

                if (slots.Length > 1)
                {
                    balances = new float[slots.Length - 1];

                    for (int j = 1; j < slots.Length; j++)
                    {
                        float number;
                        bool isNumber = float.TryParse(slots[j], NumberStyles.Currency, CultureInfo.GetCultureInfo("en-GB"), out number);
                        balances[j - 1] = number;
                    }
                }


                persons[i] = new Person(name, balances);
            }

            return persons;
        }
        static string ComposeListString(string[] items)
        {
            if (items == null)
            {
                return "";
            }
            int length = items.Length;
            switch (length)
            {
                case 0:
                    return "";
                case 1:
                    return items[0];
                case 2:
                    return string.Join(" and ", items);
                default:
                    var firstsArr = new string[items.Length - 1];
                    for (int i = 0; i < firstsArr.Length; i++)
                    {
                        firstsArr[i] = items[i];
                    }

                    string firsts = string.Join(", ", firstsArr);
                    var last = $" and {items[^1]}";
                    return firsts + last;
            }
        }
        static string[] AppendToStringArray(string[] items, string item)
        {
            string[] newArray = new string[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                newArray[i] = items[i];
            }
            newArray[^1] = item;
            return newArray;

        }
    }
}
