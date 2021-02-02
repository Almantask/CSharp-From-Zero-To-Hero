using System;
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

            var highestHistoryBalance = 0f;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = GetLastHistoryBalance(balance);
                if (lastBalance > highestHistoryBalance)
                {
                    highestHistoryBalance = lastBalance;
                }
            }

            var names = GetNamesForSameBalance(highestHistoryBalance, peopleAndBalances, GetLastHistoryBalance);

            return $"{FormatPersonName(names.Split(","))} had the most money ever. ¤{highestHistoryBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var highestBalance = 0f;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = GetLastBalance(balance);
                if (lastBalance > highestBalance)
                {
                    highestBalance = lastBalance;
                }
            }

            var names = GetNamesForSameBalance(highestBalance, peopleAndBalances, GetLastBalance);
            var splitNames = names.Split(",");

            return $"{FormatPersonName(splitNames)} {IsOrAre(splitNames.Length)} the richest {PeopleOrPerson(splitNames.Length)}. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            var lowestBalance = float.MaxValue;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = GetLastBalance(balance);
                if (lastBalance < lowestBalance)
                {
                    lowestBalance = lastBalance;
                }
            }

            var names = GetNamesForSameBalance(lowestBalance, peopleAndBalances, GetLastBalance);
            var splitNames = names.Split(",");

            return $"{FormatPersonName(splitNames)} {HasOrHave(splitNames.Length)} the least money. {FormatBalance(lowestBalance)}.";
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

        private static float GetLastBalance(string[] balance)
        {
            return float.Parse(balance[balance.Length - 1].Trim()); ;
        }

        private static string GetNamesForSameBalance(float currentBalance, string[] peopleAndBalances, Func<string[],float> calculatedBalance)
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

            return names.ToString();
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
    }
}
