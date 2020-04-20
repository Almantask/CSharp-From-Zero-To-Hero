using System;
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
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = FindPeopleBalancesByOption(peopleAndBalances, "max");

            return $"{balances[0]} had the most money ever. {balances[2]}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = FindPeopleBalancesByOption(peopleAndBalances, "loss");
            if (balances[0] == Constants.Nothing) return balances[0];

            return $"{balances[0]} lost the most money. {balances[2]}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = FindPeopleBalancesByOption(peopleAndBalances, "rich");
            var dictionary = new string[2];
            dictionary[0] = (balances[1] == "1") ? "are" : "is";
            dictionary[1] = (balances[1] == "1") ? "people" : "person";

            return $"{balances[0]} {dictionary[0]} the richest {dictionary[1]}. {balances[2]}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            var balances = FindPeopleBalancesByOption(peopleAndBalances, "poor");
            var dictionary = new string[1];
            dictionary[0] = (balances[1] == "1") ? "have" : "has";

            return $"{balances[0]} {dictionary[0]} the least money. {balances[2]}.";
        }
        
        private static string[] FindPeopleBalancesByOption(string[] balances, string option)
        {
            if (!IsOptionValid(option)) throw new InvalidBalancesException($"{option} is not a valid option.");
            FileCleaner.ValidateBalancesFile(string.Join(Environment.NewLine, balances));

            var nameData = new string[balances.Length];
            var moneyData = new decimal?[balances.Length];

            for (var i = 0; i < nameData.Length; i++)
            {
                var data = balances[i].Split(",");
                // Save name
                nameData[i] = data[0];
                var balanceHistory = ConvertToArrayOfDecimal(data[1..]);
                // Save money value based on option
                if (balanceHistory.Length == 0)
                {
                    moneyData[i] = null;
                    continue;
                }
                moneyData[i] = ProcessDataByOption(balanceHistory, option);
            }
            if (option == "loss" && (decimal)moneyData.Min() >= 0) return new string[]{Constants.Nothing};
            
            return ProcessNameAndValue(nameData, moneyData, option);
        }

        private static decimal ProcessDataByOption(decimal[] balanceHistory, string option)
        {
            switch (option)
            {
                case "max":
                    return balanceHistory.Max();
                case "loss":
                    return CalculateNetGain(balanceHistory).Min();
                case "rich":
                case "poor":
                    return balanceHistory[^1];
                default:
                    return 0;
            }
        }

        private static decimal[] CalculateNetGain(decimal[] moneyList)
        {
            if (moneyList.Length == 1) return moneyList;
            var balanceNetGain = new decimal[moneyList.Length-1];

            for (var i = 0; i < balanceNetGain.Length; i++)
            {
                balanceNetGain[i] = moneyList[i + 1] - moneyList[i];
            }

            return balanceNetGain;
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

        private static string[] ProcessNameAndValue(string[] namesData, decimal?[] moneyData, string option)
        {
            var isMaxValue = option == "max" || option == "rich";
            var moneyToCompare = (isMaxValue) ? (decimal)moneyData.Max() : (decimal)moneyData.Min();
            var indexOfNames = moneyData.Select((b, i) => b == moneyToCompare ? i : -1).Where(i => i != -1).ToArray();

            var names = namesData[indexOfNames[0]];
            if (indexOfNames.Length == 1) return new string[] { names, "0", FixMoneyFormat(moneyToCompare) };
            for (var i = 1; i < indexOfNames.Length - 1; i++)
            {
                names += $", {namesData[indexOfNames[i]]}";
            }
            names += $" and {namesData[indexOfNames[^1]]}";
            return new string[] { names, "1", FixMoneyFormat(moneyToCompare) };
        }

        private static string FixMoneyFormat(decimal value)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var currencySign = (value < 0) ? "-" : "";
            const string currencySymbol = "¤";

            return $"{currencySign}{currencySymbol}{Math.Abs(value)}";
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return (peopleAndBalances == null || peopleAndBalances.Length == 0);
        }

        private static bool IsOptionValid(string option)
        {
            var validOptions = new string[] { "max", "loss", "rich", "poor" };
            return (validOptions.Contains(option));
        }
    }
}