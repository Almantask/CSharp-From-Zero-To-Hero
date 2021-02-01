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

            var names = GetNamesForSameBalance(highestBalance, peopleAndBalances);

            return $"{FormatPersonName(names.Split(","))} had the most money ever. ¤{highestBalance}.";
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

            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsNullOrEmpty(peopleAndBalances)) return DEFAULT_MESSAGE;

            return "";
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

        private static float GetLastBalance(string[] balance)
        {
            var lastBalance = float.Parse(balance[balance.Length - 1].Trim());
            if (lastBalance == 0)
            {
                var index = balance.Length - 2 >= 1 ? balance.Length - 2 : balance.Length - 1;
                lastBalance = float.Parse(balance[index].Trim());
            }

            return lastBalance;
        }

        private static string GetNamesForSameBalance(float currentBalance, string[] peopleAndBalances)
        {
            var names = new StringBuilder();

            for (var i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var name = balance[0];
                var lastBalance = GetLastBalance(balance);
                if (lastBalance != currentBalance) continue;
                names.Append(names.Length > 0 ? $", {name}" : $"{name}");
            }

            return names.ToString();
        }

        private static bool IsNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }
    }
}
