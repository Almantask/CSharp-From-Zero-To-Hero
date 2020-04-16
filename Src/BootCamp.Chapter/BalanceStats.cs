using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// ToDo: refactor most of the functions to remove repetitions.

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var firstAccount = peopleAndBalances[0].Split(',');
            var accountOwner = firstAccount[0];
            var balanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(firstAccount);
            var highestBalanceEver = ArrayOperations.FindLargestDecimalInArray(balanceHistory); // We assume that the first array/account has the highest balance ever

            var individualsWithHighestBalanceEver = new[] { accountOwner }; // We store the name of the first individual

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentBalanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(currentAccount);
                var currentHighestBalance = ArrayOperations.FindLargestDecimalInArray(currentBalanceHistory);

                if (currentHighestBalance > highestBalanceEver)
                {
                    individualsWithHighestBalanceEver = new[] { currentAccountOwner };
                    highestBalanceEver = currentHighestBalance;
                } 
                else if (currentHighestBalance == highestBalanceEver)
                {
                    individualsWithHighestBalanceEver = ArrayOperations.AppendString(individualsWithHighestBalanceEver, currentAccount[0]);
                }
            }

            return $"{ArrayOperations.FormatArrayToString(individualsWithHighestBalanceEver)} had the most money ever. ¤{highestBalanceEver}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            var firstAccount = peopleAndBalances[0].Split(",");
            var accountOwner = firstAccount[0];
            var balanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(firstAccount);

            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var firstAccount = peopleAndBalances[0].Split(',');
            var accountOwner = firstAccount[0];
            var accountBalance = decimal.TryParse(firstAccount[^1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed) ? parsed : 0.0m; // No need to parse the whole array, we just need the last element
            var highestBalance = accountBalance; // We assume that the first array/account holds the richest person

            var richestIndividuals = new[] { accountOwner }; // We store the name of the first individual who is assumed to be the richest

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentBalance = decimal.TryParse(currentAccount[^1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedBalance) ? parsedBalance : 0.0m;

                if (currentBalance > highestBalance)
                {
                    highestBalance = currentBalance;
                    richestIndividuals = new[] { currentAccountOwner };
                }
                else if (currentBalance == highestBalance)
                {
                    richestIndividuals = ArrayOperations.AppendString(richestIndividuals, currentAccountOwner);
                }
            }

            if (richestIndividuals.Length == 1)
            {
                return $"{ArrayOperations.FormatArrayToString(richestIndividuals)} is the richest person. ¤{highestBalance}.";
            }

            return $"{ArrayOperations.FormatArrayToString(richestIndividuals)} are the richest people. ¤{highestBalance}."; 
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var firstAccount = peopleAndBalances[0].Split(',');
            var accountOwner = firstAccount[0];
            var balanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(firstAccount[^1..]);
            var lowestBalanceEver = ArrayOperations.FindSmallestDecimalInArray(balanceHistory); // We assume that the first account has the smallest balance ever

            var individualsWithLowestBalance = new[] { accountOwner }; // We store the name of the first individual who is assumed to be the poorest

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentBalanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(currentAccount[^1..]);
                var currentLowestBalance = ArrayOperations.FindSmallestDecimalInArray(currentBalanceHistory);

                if (currentLowestBalance < lowestBalanceEver)
                {
                    lowestBalanceEver = currentLowestBalance;
                    individualsWithLowestBalance = new[] { currentAccountOwner };
                }
                else if (currentLowestBalance == lowestBalanceEver)
                {
                    individualsWithLowestBalance = ArrayOperations.AppendString(individualsWithLowestBalance, currentAccountOwner);
                }
            }

            var formattedLowestBalance = $"¤{lowestBalanceEver}";
            if (lowestBalanceEver < 0)
            {
                formattedLowestBalance = $"-¤{-lowestBalanceEver}";
            }

            if (individualsWithLowestBalance.Length == 1)
            {
                return $"{ArrayOperations.FormatArrayToString(individualsWithLowestBalance)} has the least money. {formattedLowestBalance}.";
            }

            return $"{ArrayOperations.FormatArrayToString(individualsWithLowestBalance)} have the least money. ¤{lowestBalanceEver}.";
        }
    }
}
