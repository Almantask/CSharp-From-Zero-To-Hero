using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var highestBalanceEver = balances.GetMaxBalance();
            if (IsNullOrEmpty(highestBalanceEver)) return Constants.Nothing;

            return $"{highestBalanceEver[0]} had the most money ever. {highestBalanceEver[1]}.";
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var personWithBiggestLoss = balances.GetMaxLoss();
            if (IsNullOrEmpty(personWithBiggestLoss)) return Constants.Nothing;

            return $"{personWithBiggestLoss[0]} lost the most money. {personWithBiggestLoss[1]}.";
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var richestPerson = balances.GetRichestPerson();
            if (IsNullOrEmpty(richestPerson)) return Constants.Nothing;

            var dictionary = new string[2];
            dictionary[0] = (IsMultiplePeople(richestPerson[0])) ? "are" : "is";
            dictionary[1] = (IsMultiplePeople(richestPerson[0])) ? "people" : "person";
            return $"{richestPerson[0]} {dictionary[0]} the richest {dictionary[1]}. {richestPerson[1]}.";
        }

        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = CreateBalanceDatabase(peopleAndBalances);
            var mostPoorPerson = balances.GetMostPoorPerson();
            if (IsNullOrEmpty(mostPoorPerson)) return Constants.Nothing;

            var dictionary = new string[1];
            dictionary[0] = (IsMultiplePeople(mostPoorPerson[0])) ? "have" : "has";

            return $"{mostPoorPerson[0]} {dictionary[0]} the least money. {mostPoorPerson[1]}.";
        }

        private static BalanceDatabase CreateBalanceDatabase(string[] peopleAndBalances)
        {
            var balances = new BalanceDatabase();

            foreach (var personStats in peopleAndBalances)
            {
                var stats = personStats.Split(", ");
                var name = stats[0];
                ValidateName(name);

                var balanceInfo = new decimal[0];
                if (stats.LongLength > 1)balanceInfo = ConvertToArrayOfDecimal(stats[1..]);

                balances.AddNewPerson(name, balanceInfo.ToList());
            }
            return balances;
        }

        private static decimal[] ConvertToArrayOfDecimal(string[] numbers)
        {
            var emptyStrings = numbers.Count(value => string.IsNullOrEmpty(value) || value == " ");

            var decimalArray = new decimal[numbers.Length - emptyStrings];
            var newIndex = 0;
            foreach (var currency in numbers)
            {
                if (string.IsNullOrEmpty(currency)) continue;
                if (!decimal.TryParse(currency, NumberStyles.Currency, CultureInfo.GetCultureInfo(Constants.CultureLocale), out var value)) continue;

                decimalArray[newIndex] = value;
                newIndex++;
            }

            return decimalArray;
        }

        private static void ValidateName(string name)
        {
            var whiteList = new[]
            {
                ' ',
                '-',
                '\''
            };

            var isValid = name.All(letter => char.IsLetter(letter) || whiteList.Contains(letter));
            if (!isValid) throw new InvalidBalancesException($"{name} is an invalid name.");
        }

        private static bool IsMultiplePeople(string names)
        {
            return names.Contains(",") || names.Contains(" and ");
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }
    }
}
