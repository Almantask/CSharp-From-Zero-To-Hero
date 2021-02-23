using System;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>

        private const string DEFAULT_MESSAGE = "N/A.";

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var highestHistoryBalance = peopleAndBalances.Max(GetLastHistoryBalance);

            var names = peopleAndBalances.GetNamesForSameBalance(highestHistoryBalance, GetLastHistoryBalance);

            return $"{FormatPersonName(names)} had the most money ever. {FormatBalance(highestHistoryBalance)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var peopleLossBalance = new string[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                if (balance.Length <= 2)
                {
                    peopleLossBalance[i] = balance[0] + ",NaN";
                }
                else
                {
                    peopleLossBalance[i] = balance[0] + "," + (balance.GetLastBalance() - balance.GetBalanceBackwards(2)).ToString(CultureInfo.InvariantCulture);
                }
            }

            var biggestLossBalance = peopleLossBalance.Min(GetLastBalance);

            var names = peopleLossBalance.GetNamesForSameBalance(biggestLossBalance, GetLastBalance);

            return float.IsNaN(biggestLossBalance) ? DEFAULT_MESSAGE : $"{FormatPersonName(names)} lost the most money. {FormatBalance(biggestLossBalance)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var highestBalance = peopleAndBalances.Max(GetLastBalance);

            var names = peopleAndBalances.GetNamesForSameBalance(highestBalance, GetLastBalance);

            return $"{FormatPersonName(names)} {IsOrAre(names.Length)} the richest {PeopleOrPerson(names.Length)}. {FormatBalance(highestBalance)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var lowestBalance = peopleAndBalances.Min(GetLastBalance);

            var names = peopleAndBalances.GetNamesForSameBalance(lowestBalance, GetLastBalance);

            return $"{FormatPersonName(names)} {HasOrHave(names.Length)} the least money. {FormatBalance(lowestBalance)}.";
        }

        private static string FormatPersonName(string[] names)
        {
            var namesToDisplay = new StringBuilder();

            for (var i = 0; i < names.Length; i++)
            {
                if (i == 0)
                {
                    namesToDisplay.Append(names[i]);
                }
                else if (i != names.Length - 1)
                {
                    namesToDisplay.Append($",{names[i]}");
                }
                else
                {
                    namesToDisplay.Append($" and{names[i]}");
                }
            }

            return namesToDisplay.ToString();
        }

        private static float GetLastHistoryBalance(string[] balance)
        {
            var index = balance.Length - 1;
            var lastBalance = 0f;
            while (index >= 1)
            {
                lastBalance = float.Parse(balance[index].Trim());
                index -= 1;
                if (lastBalance != 0)
                {
                    index = 0;
                }
            }

            return lastBalance;
        }

        private static float GetLastBalance(this string[] balance)
        {
            return balance.GetBalanceBackwards(1);
        }

        private static float GetBalanceBackwards(this string[] balance, int index)
        {
            var stringBalance = balance[balance.Length - index].Trim();
            float.TryParse(stringBalance,out var floatBalance);
            return floatBalance;
        }

        private static string[] GetNamesForSameBalance(this string[] peopleAndBalances, float currentBalance, Func<string[],float> calculatedBalance)
        {
            var names = new StringBuilder();

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var name = balance[0];
                var lastBalance = calculatedBalance(balance);
                if (lastBalance != currentBalance) continue;
                names.Append(names.Length > 0 ? $", {name}" : $"{name}");
            }

            return names.ToString().Split(",");
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }

        private static string IsOrAre(int count)
        {
            return count > 1 ? "are" : "is";
        }

        private static string PeopleOrPerson(int count)
        {
            return count > 1 ? "people" : "person";
        }

        private static string FormatBalance(float balance)
        {
            return balance >= 0 ? $"¤{balance}" : $"-¤{balance * -1}";
        }

        private static string HasOrHave(int count)
        {
            return count > 1 ? "have" : "has";
        }

        private static float Min(this string[] peopleAndBalances, Func<string[], float> calculatedBalance)
        {
            var lowestBalance = float.MaxValue;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = calculatedBalance(balance);
                if (lastBalance < lowestBalance)
                {
                    lowestBalance = lastBalance;
                    continue;
                }

                if (float.IsNaN(lastBalance))
                {
                    lowestBalance = float.NaN;
                }
            }
            return lowestBalance;
        }

        private static float Max(this string[] peopleAndBalances, Func<string[], float> calculatedBalance)
        {
            var highestBalance = 0f;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = calculatedBalance(balance);
                if (lastBalance > highestBalance)
                {
                    highestBalance = lastBalance;
                }
            }

            return highestBalance;
        }
    }
}
