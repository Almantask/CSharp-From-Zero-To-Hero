using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            var maxBalance = 0m;
            var name = "";

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var balance = GetLargestBalance(peopleBalances);

                if (balance >= maxBalance)
                {
                    if (balance > maxBalance)
                    {
                        name = "";
                    }
                    if (name != "")
                    {
                        name += ", ";
                    }
                    name += peopleBalances[0];

                    maxBalance = balance;
                }
            }

            SetMoneyFormat();
            var maxBalanceNoComma = RemoveComma($"{maxBalance:C0}");
            return $"{ReplaceLastComma(name)} had the most money ever. {maxBalanceNoComma}.";
        }

        private static decimal GetLargestBalance(string[] peopleBalances)
        {
            var maxBalance = 0m;

            for (var i = 1; i < peopleBalances.Length; i++)
            {
                var isBalanceValid = decimal.TryParse(peopleBalances[i], out var balance);

                if (isBalanceValid && balance > maxBalance)
                {
                    maxBalance = balance;
                }
            }

            return maxBalance;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            var biggestLossEver = decimal.MaxValue;
            var name = "";

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");

                if (peopleBalances.Length <= 2)
                {
                    continue;
                }

                var biggestLossForPerson = GetBiggestLossForPerson(peopleBalances);

                if (biggestLossForPerson < biggestLossEver)
                {
                    biggestLossEver = biggestLossForPerson;
                    name = peopleBalances[0];
                }
            }

            if (name == "")
            {
                return "N/A.";
            }

            SetMoneyFormat();
            var biggestLossEverNoComma = RemoveComma($"{biggestLossEver:C0}").Replace("(", "-").Replace(")", ""); ;
            return $"{name} lost the most money. {biggestLossEverNoComma}.";
        }

        private static decimal GetBiggestLossForPerson(string[] peopleBalances)
        {
            var biggestLoss = decimal.MaxValue;

            for (var i = 1; i < peopleBalances.Length; i++)
            {
                for (var j = i + 1; j < peopleBalances.Length; j++)
                {
                    var isBeforeBalanceValid = decimal.TryParse(peopleBalances[i], out var beginAmount);
                    var isAfterBalanceValid = decimal.TryParse(peopleBalances[j], out var endAmount);

                    if (isBeforeBalanceValid && isAfterBalanceValid)
                    {
                        var loss = endAmount - beginAmount;
                        if (loss < biggestLoss)
                        {
                            biggestLoss = loss;
                        }
                    }
                }
            }

            return biggestLoss;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            var maxBalance = 0m;
            var name = "";

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var isBalanceValid = decimal.TryParse(peopleBalances[peopleBalances.Length - 1], out var balance);
                
                if (isBalanceValid && balance >= maxBalance)
                {
                    if (balance > maxBalance)
                    {
                        name = "";
                    }
                    if (name != "")
                    {
                        name += ", ";
                    }
                    name += peopleBalances[0];

                    maxBalance = balance;
                }
            }

            SetMoneyFormat();
            var maxBalanceNoComma = RemoveComma($"{maxBalance:C0}");
            var word = name.Contains(", ") ? "are" : "is";
            var word2 = name.Contains(", ") ? "people" : "person";
            return $"{ReplaceLastComma(name)} {word} the richest {word2}. {maxBalanceNoComma}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }

            var minBalance = decimal.MaxValue;
            var name = "";

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var isBalanceValid = decimal.TryParse(peopleBalances[peopleBalances.Length - 1], out var balance);

                if (isBalanceValid && balance <= minBalance)
                {
                    if (balance < minBalance)
                    {
                        name = "";
                    }
                    if (name != "")
                    {
                        name += ", ";
                    }
                    name += peopleBalances[0];

                    minBalance = balance;
                }
            }

            var word = name.Contains(", ") ? "have" : "has";
            SetMoneyFormat();
            var minBalanceNoComma = RemoveComma($"{minBalance:C0}").Replace("(", "-").Replace(")", "");
            if (minBalance < 0)
            {
                minBalanceNoComma = $"{minBalanceNoComma}";
            }
            return $"{ReplaceLastComma(name)} {word} the least money. {minBalanceNoComma}.";
        }

        private static string ReplaceLastComma(string name)
        {
            var lastComma = name.LastIndexOf(", ");
            if (lastComma > 0)
            {
                name = name.Remove(lastComma, 2).Insert(lastComma, " and ");
            }

            return name;
        }

        private static bool IsArrayNullOrEmpty(string[] array)
        {
            if (array == null || array.Length == 0)
            {
                return true;
            }
            return false;
        }

        private static void SetMoneyFormat()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private static string RemoveComma(string data)
        {
            return data.Replace(",", "");
        }
    }
}
