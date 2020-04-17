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
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var highestBalanceEver = ProcessFirstAccount(peopleAndBalances, OperationType.FindLargestValue, out string[] names);
            var individualsWithHighestBalanceEver = names;

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
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var biggestLoss = ProcessFirstAccount(peopleAndBalances, OperationType.FindBiggestDiscrepancy, out string[] names);
            var individualWithBiggestLoss = names;

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentBalanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(currentAccount[1..]);
                var currentBiggestLoss = 0.0m;

                if (currentBalanceHistory.Length >= 2)
                {
                    currentBiggestLoss = ArrayOperations.FindLargestDecimalInArray(currentBalanceHistory) - ArrayOperations.FindSmallestDecimalInArray(currentBalanceHistory);
                }
                else
                {
                    continue;
                }

                if (currentBiggestLoss > biggestLoss)
                {
                    biggestLoss = currentBiggestLoss;
                    individualWithBiggestLoss = new[] { currentAccountOwner };
                }
                else if (currentBiggestLoss == biggestLoss)
                {
                    individualWithBiggestLoss = ArrayOperations.AppendString(individualWithBiggestLoss, currentAccountOwner);
                }
            }

            if (biggestLoss == 0.0m)
            {
                return "N/A.";
            }

            return $"{ArrayOperations.FormatArrayToString(individualWithBiggestLoss)} lost the most money. -¤{biggestLoss}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var highestBalance = ProcessFirstAccount(peopleAndBalances, OperationType.FindLastValue, out string[] names);
            var richestIndividuals = names;

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

            var lowestBalanceEver = ProcessFirstAccount(peopleAndBalances, OperationType.FindSmallestValue, out string[] names);
            var individualsWithLowestBalance = names;

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

        /// <summary>
        /// Process the first element of an inputted string array based on a selected operation type. Returns a decimal and an array of strings.
        /// </summary>
        /// <param name="inputArray">The array where the first element should be processed.</param>
        /// <param name="operationType">The operation type which determines how the passed array will be processed. Available types are: FindLargestValue, FindSmallestValue, FindBiggestDiscrepancy, FindLastValue</param>
        /// <param name="names">The array of string which will be returned in addition to a decimal.</param>
        /// <returns></returns>
        private static decimal ProcessFirstAccount(string[] inputArray, OperationType operationType, out string[] names)
        {
            var firstAccount = inputArray[0].Split(',');
            var accountOwner = firstAccount[0];
            var balanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(firstAccount[1..]);

            decimal searchedBalance = 0.0m;
            switch (operationType)
            {
                case OperationType.FindLargestValue:
                    searchedBalance = ArrayOperations.FindLargestDecimalInArray(balanceHistory);
                    break;

                case OperationType.FindSmallestValue:
                    searchedBalance = ArrayOperations.FindSmallestDecimalInArray(balanceHistory);
                    break;

                case OperationType.FindBiggestDiscrepancy:
                    if (balanceHistory.Length >= 2) // We only want to calculate loss if there are more than 2 transactions in the individual's balance history
                        searchedBalance = ArrayOperations.FindLargestDecimalInArray(balanceHistory) - ArrayOperations.FindSmallestDecimalInArray(balanceHistory);
                    else
                        searchedBalance = 0.0m; // It only makes sense to return a value higher than 0 if there are actual transactions proving that
                    break;

                case OperationType.FindLastValue:
                    searchedBalance = balanceHistory[^1];
                    break;
            }

            names = new[] { accountOwner };
            return searchedBalance;
        }
    }
}
