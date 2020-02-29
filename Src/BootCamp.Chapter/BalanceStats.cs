using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private const string NotAvailable = "N/A.";

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return NotAvailable;
            }

            var maxBalance = 0m;
            var name = new StringBuilder();

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var balance = GetLargestBalance(peopleBalances);
                SetNames(ref name, ref maxBalance, peopleBalances, balance);
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var maxBalanceNoComma = RemoveComma($"{maxBalance:C0}");
            return $"{FixPlural(name.ToString())} had the most money ever. {maxBalanceNoComma}.";

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

        private static void SetNames(ref StringBuilder name, ref decimal maxBalance, string[] peopleBalances, decimal balance)
        {
            if (balance >= maxBalance)
            {
                if (balance > maxBalance)
                {
                    name = new StringBuilder();
                }

                if (name.Length != 0)
                {
                    name.Append(", ");
                }

                name.Append(peopleBalances[0]); //Builds list of names with highest balance
                maxBalance = balance;
            }
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return NotAvailable;
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
                return NotAvailable;
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var biggestLossEverNoComma = RemoveComma($"{biggestLossEver:C0}").Replace("(", "-").Replace(")", "");
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
                        biggestLoss = GetBiggestLoss(biggestLoss, beginAmount, endAmount);
                    }
                }
            }

            return biggestLoss;
        }

        private static decimal GetBiggestLoss(decimal biggestLoss, decimal beginAmount, decimal endAmount)
        {
            var loss = endAmount - beginAmount;
            var bigLoss = biggestLoss;

            if (loss < bigLoss)
            {
                bigLoss = loss;
            }

            return bigLoss;
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return NotAvailable;
            }

            var maxBalance = 0m;
            var name = new StringBuilder();

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var isBalanceValid = decimal.TryParse(peopleBalances[peopleBalances.Length - 1], out var balance);

                if (isBalanceValid)
                {
                    SetNames(ref name, ref maxBalance, peopleBalances, balance);
                }
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var maxBalanceNoComma = RemoveComma($"{maxBalance:C0}");
            var word1 = name.ToString().Contains(", ") ? "are" : "is";
            var word2 = name.ToString().Contains(", ") ? "people" : "person";
            return $"{FixPlural(name.ToString())} {word1} the richest {word2}. {maxBalanceNoComma}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return NotAvailable;
            }

            var minBalance = decimal.MaxValue;
            var name = new StringBuilder();

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var peopleBalances = peopleAndBalances[i].Split(",");
                var isBalanceValid = decimal.TryParse(peopleBalances[peopleBalances.Length - 1], out var balance);

                if (isBalanceValid)
                {
                    GetPoorest(ref name, ref minBalance, peopleBalances, balance);
                }
            }

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            var minBalanceNoComma = RemoveComma($"{minBalance:C0}").Replace("(", "-").Replace(")", "");
            var word = name.ToString().Contains(", ") ? "have" : "has";
            return $"{FixPlural(name.ToString())} {word} the least money. {minBalanceNoComma}.";
        }
        private static void GetPoorest(ref StringBuilder mostPoorPerson, ref decimal minBalance, string[] peopleBalances, decimal balance)
        {
            if (balance <= minBalance)
            {
                if (balance < minBalance)
                {
                    mostPoorPerson = new StringBuilder();
                }

                if (mostPoorPerson.Length != 0)
                {
                    mostPoorPerson.Append(", ");
                }

                mostPoorPerson.Append(peopleBalances[0]);
                minBalance = balance;
            }
        }

        private static string FixPlural(string name)
        {
            var lastComma = name.LastIndexOf(", ", StringComparison.InvariantCulture);

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

        private static string RemoveComma(string data)
        {
            return data.Replace(",", "");
        }
    }
}
