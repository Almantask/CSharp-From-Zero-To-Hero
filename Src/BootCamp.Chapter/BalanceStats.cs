using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) return "N/A.";

            var names = "";
            var highestBalance = 0f;

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var lastBalance = float.Parse(balance[balance.Length - 1].Trim());
                if (lastBalance == 0)
                {
                    var index = balance.Length - 2 >= 1 ? balance.Length - 2 : balance.Length - 1;
                    lastBalance = float.Parse(balance[index].Trim());
                }
                if(lastBalance > highestBalance)
                {
                    highestBalance = lastBalance;
                }
            }

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var balance = peopleAndBalances[i].Split(",");
                var name = balance[0];
                var lastBalance = float.Parse(balance[balance.Length - 1].Trim());
                if (lastBalance == 0)
                {
                    var index = balance.Length - 2 >= 1 ? balance.Length - 2 : balance.Length - 1;
                    lastBalance = float.Parse(balance[index].Trim());
                }
                if (lastBalance == highestBalance)
                {
                    if(names != "")
                    {
                        names += $", {name}";
                    } 
                    else
                    {
                        names += $"{name}";
                    }
                }
            }

            return $"{FormatPersonName(names.Split(","))} had the most money ever. ¤{highestBalance}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
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
    }
}
