using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

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
            Thread.CurrentThread.CurrentCulture = Config.Culture();

            var (names, money, isPlural) = ReturnNamesMoneyAndIsPlural(peopleAndBalances, "max");

            return $"{names} had the most money ever. {FixMoneyFormat(money)}.";
        }
        
        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            Thread.CurrentThread.CurrentCulture = Config.Culture();

            var (names, money, isPlural) = ReturnNamesMoneyAndIsPlural(peopleAndBalances, "min");
            if (money >= 0) return "N/A.";

            return $"{names} lost the most money. {FixMoneyFormat(money)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            Thread.CurrentThread.CurrentCulture = Config.Culture();

            var (names, money, isPlural) = ReturnNamesMoneyAndIsPlural(peopleAndBalances, "rich");
            var dictionary = new string[]
            {
                (isPlural) ? "are" : "is",          // [0]
                (isPlural) ? "people" : "person"    // [1]
            };

            return $"{names} {dictionary[0]} the richest {dictionary[1]}. {FixMoneyFormat(money)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return Constants.Nothing;
            Thread.CurrentThread.CurrentCulture = Config.Culture();

            var (names, money, isPlural) = ReturnNamesMoneyAndIsPlural(peopleAndBalances, "poor");
            var dictionary = new string[]
            {
                (isPlural) ? "have" : "has",        // [0]
            };

            return $"{names} {dictionary[0]} the least money. {FixMoneyFormat(money)}.";
        }

        private static (string names, decimal money, bool isPlural) ReturnNamesMoneyAndIsPlural(string[] peopleAndBalances, string option)
        {
            if (!IsOptionValid(option)) throw new Exception($"{option} is not a valid option for function ProcessPeopleBalance().");

            var (name, money) = ProcessPeopleBalance(peopleAndBalances, option);
            var people = new List<string>();
            var moneyToCompare = (option == "max" || option == "rich") ? money.Max() : money.Min();

            for (var i = 0; i < money.Count; i++)
            {
                if (money[i] == moneyToCompare) people.Add(name[i]);
            }

            var (processedNames, isPlural) = ProcessName(people);

            return (processedNames, moneyToCompare, isPlural);
        }

        private static (List<string> name, List<decimal>) ProcessPeopleBalance(string[] peopleAndBalances, string option)
        {
            var nameList = new List<string>();
            var moneyProcessed = new List<decimal>();
            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                try
                {
                    var moneyList = CheckData(peopleAndBalances[i], out var name);
                    if (string.IsNullOrEmpty(name)) throw new Exception(Constants.GenericMessageError);

                    switch (option)
                    {
                        case "max" when moneyList.Count == 0:
                            continue;
                        case "max":
                            moneyProcessed.Add(moneyList.Max());
                            break;
                        case "min" when moneyList.Count == 0:
                            continue;
                        case "min":
                            moneyProcessed.Add(CheckBalance(moneyList, option));
                            break;
                        case "rich":
                        case "poor":
                        {
                            if (moneyList.Count < 1) continue;
                            moneyProcessed.Add(moneyList[^1]);
                            break;
                        }
                    }

                    nameList.Add(name);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                    Console.WriteLine($"The following data from index: {i} is not valid, skipping.");
                    Console.WriteLine($"\"{peopleAndBalances[i]}\"");
                    Console.ResetColor();
                    continue;
                }
            }

            if (nameList.Count != moneyProcessed.Count || nameList == null || moneyProcessed == null || nameList.Count == 0 || moneyProcessed.Count == 0)
            {
                throw new Exception($"Something went very wrong in function ProcessPeopleBalance().");
            }
            return (nameList, moneyProcessed);
        }

        private static decimal CheckBalance(List<decimal> moneyList, string option)
        {
            var balance = new List<decimal>();
            if (moneyList.Count == 1) return moneyList[0];
            for (var i = 0; i < moneyList.Count - 1; i++)
            {
                balance.Add(moneyList[i+1] - moneyList[i]);
            }

            return option switch
            {
                "max" => balance.Max(),
                "min" => balance.Min(),
                _ => 0
            };
        }

        private static List<decimal> CheckData(string line, out string name)
        {
            const string emptyLine = "Line is null or empty.";
            const string emptyName = "Name of account not found.";
            const string nonLatin = "[Name] has non-latin character valid for name.";
            const string moneyError = "Error in money registry.";
            name = null;

            var data = line.Split(",");
            if (data.Length == 0) throw new InvalidBalancesException(emptyLine);
            if (data[0] == "" || string.IsNullOrWhiteSpace(data[0])) throw new InvalidBalancesException(emptyName);
            if (!Regex.IsMatch(data[0], Constants.AllCommonLatinLetters)) throw new InvalidBalancesException(nonLatin);

            var moneyList = new List<decimal>();

            var successAttempts = 0;
            for (var i = 1; i < data.Length; i++)
            {
                if (data[i] == "" || string.IsNullOrWhiteSpace(data[i]))
                {
                    successAttempts++;
                    continue;
                }
                var isMoney = decimal.TryParse(data[i], NumberStyles.Currency, CultureInfo.CurrentCulture, out var money);
                if (!isMoney) throw new InvalidBalancesException($"{moneyError} | \"{data[i]}\" not valid {money}");

                moneyList.Add(money);
                successAttempts++;
            }

            if (successAttempts != data.Length - 1) throw new InvalidBalancesException($"{Constants.GenericMessageError} | Function: CheckData()"); //False -> fallback

            name = data[0];
            return moneyList;
        }

        private static (string names, bool isPlural) ProcessName(List<string> names)
        {
            if (names.Count == 1) return (names[0], false);

            var first = string.Join(", ", names.Take(names.Count() - 1));
            var last = $" and {names.Last()}";

            return ($"{first}{last}", true);

        }

        private static string FixMoneyFormat(decimal value)
        {
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
            var validOptions = new string[] { "max", "min", "rich", "poor" };
            return (validOptions.Contains(option));
        }
    }
}
