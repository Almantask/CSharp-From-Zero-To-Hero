using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private const string NotAvailable = "N/A.";
        private const decimal Epsilon = 0.00001m;

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var largestHistoricBalance = GetLargestHistoricBalance(people);
            var largestHistoricBalanceNames = GetLargestHistoricBalanceNames(people, largestHistoricBalance);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var largestHistoricBalanceNoComma = RemoveComma($"{largestHistoricBalance:C0}");

            return $"{FixPlural(largestHistoricBalanceNames)} had the most money ever. {largestHistoricBalanceNoComma}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var isBiggestLossValid = TryGetBiggestLoss(people, out var biggestLoss);

            if (!isBiggestLossValid)
            {
                return NotAvailable;
            }

            var biggestLossNames = GetBiggestLossNames(people, biggestLoss);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            return $"{biggestLossNames} lost the most money. -{biggestLoss:C0}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var largestCurrentBalance = GetLargestCurrentBalance(people);
            var largestCurrentBalancesNames = GetLargestCurrentNames(people, largestCurrentBalance);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var word1 = largestCurrentBalancesNames.Contains(", ") ? "are" : "is";
            var word2 = largestCurrentBalancesNames.Contains(", ") ? "people" : "person";
            var largestCurrentBalanceNoComma = RemoveComma($"{largestCurrentBalance:C0}");

            return $"{FixPlural(largestCurrentBalancesNames)} {word1} the richest {word2}. {largestCurrentBalanceNoComma}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(Person[] people)
        {
            if (people == null)
            {
                return NotAvailable;
            }

            var smallestCurrentBalance = GetSmallestCurrentBalance(people);
            var smallestCurrentBalancesNames = GetSmallestCurrentBalanceNames(people, smallestCurrentBalance);

            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var minBalanceNoComma = RemoveComma($"{smallestCurrentBalance:C0}").Replace("(", "-").Replace(")", "");
            var word = smallestCurrentBalancesNames.Contains(", ") ? "have" : "has";

            return $"{FixPlural(smallestCurrentBalancesNames)} {word} the least money. {minBalanceNoComma}.";
        }

        private static string GetLargestHistoricBalanceNames(Person[] people, decimal largestHistoricBalance)
        {
            var names = new StringBuilder();

            for (var i = 0; i < people.Length; i++)
            {
                if (HasLargestHistoricBalance(people[i].GetBalances(), largestHistoricBalance))
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName()); //Builds list of names with highest historical balance
                }
            }

            return names.ToString();
        }

        private static bool HasLargestHistoricBalance(decimal[] balances, decimal largestHistoricBalance)
        {
            for (var i = 0; i < balances.Length; i++)
            {
                if (balances[i] == largestHistoricBalance)
                {
                    return true;
                }
            }

            return false;
        }

        private static decimal GetLargestHistoricBalance(Person[] people)
        {
            var largestBalance = decimal.MinValue;

            for (var i = 0; i < people.Length; i++)
            {
                var balance = GetLargestHistoricPersonBalance(people[i].GetBalances());

                if (balance > largestBalance)
                {
                    largestBalance = balance;
                }
            }

            return largestBalance;
        }

        private static decimal GetLargestHistoricPersonBalance(decimal[] balances)
        {
            var largestBalance = decimal.MinValue;

            for (var i = 0; i < balances.Length; i++)
            {
                if (balances[i] > largestBalance)
                {
                    largestBalance = balances[i];
                }
            }

            return largestBalance;
        }

        private static decimal GetLargestCurrentBalance(Person[] people)
        {
            var largestBalance = decimal.MinValue;

            for (var i = 0; i < people.Length; i++)
            {
                var currentBalance = people[i].GetCurrentBalance();

                if (currentBalance > largestBalance)
                {
                    largestBalance = currentBalance;
                }
            }

            return largestBalance;
        }

        private static bool TryGetBiggestLoss(Person[] people, out decimal biggestLoss)
        {
            biggestLoss = decimal.MinValue;

            for (var i = 0; i < people.Length; i++)
            {
                var isBiggestLossForPersonValid = TryGetBiggestPersonLoss(people[i].GetBalances(), out var biggestLossForPerson);

                if (!isBiggestLossForPersonValid)
                {
                    biggestLoss = 0;
                    return false;
                }

                if (biggestLossForPerson > biggestLoss)
                {
                    biggestLoss = biggestLossForPerson;
                }
            }

            return true;
        }

        private static bool TryGetBiggestPersonLoss(decimal[] balances, out decimal biggestLoss)
        {
            biggestLoss = decimal.MinValue;

            if (balances.Length < 2)
            {
                biggestLoss = 0;
                return false;
            }

            for (var i = 0; i < balances.Length; i++)
            {
                for (var j = i + 1; j < balances.Length; j++)
                {
                    var loss = balances[i] - balances[j];

                    if (loss > biggestLoss)
                    {
                        biggestLoss = loss;
                    }
                }
            }

            return true;
        }
        
        private static string GetBiggestLossNames(Person[] people, decimal biggestLoss)
        {
            var names = new StringBuilder();

            for (var i = 0; i < people.Length; i++)
            {
                var hasBiggestLoss = HasBiggestLoss(people[i].GetBalances(), biggestLoss);

                if (hasBiggestLoss)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
        }

        private static bool HasBiggestLoss(decimal[] balances, decimal biggestLoss)
        {
            for (var i = 0; i < balances.Length; i++)
            {
                for (var j = i + 1; j < balances.Length; j++)
                {
                    if (IsNumberEqual(balances[i] - balances[j], biggestLoss))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool IsNumberEqual(decimal num1, decimal num2)
        {
            if (Math.Abs(num1 - num2) < Epsilon)
            {
                return true;
            }

            return false;
        }

        private static string GetLargestCurrentNames(Person[] people, decimal largestCurrentBalance)
        {
            var names = new StringBuilder();

            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() == largestCurrentBalance)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
        }

        private static decimal GetSmallestCurrentBalance(Person[] people)
        {
            var smallestBalance = decimal.MaxValue;

            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() < smallestBalance)
                {
                    smallestBalance = people[i].GetCurrentBalance();
                }
            }

            return smallestBalance;
        }

        private static string GetSmallestCurrentBalanceNames(Person[] people, decimal smallestCurrentBalance)
        {
            var names = new StringBuilder();

            for (var i = 0; i < people.Length; i++)
            {
                if (people[i].GetCurrentBalance() == smallestCurrentBalance)
                {
                    if (names.Length > 0)
                    {
                        names.Append(", ");
                    }

                    names.Append(people[i].GetName());
                }
            }

            return names.ToString();
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

        private static string RemoveComma(string data)
        {
            return data.Replace(",", "");
        }
    }
}
