using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace BootCamp.Chapter
{
    static class AccountProcessor
    {
        /// <summary>
        /// Process the first element of an inputted string array based on a selected operation type. Returns a decimal and an array of strings.
        /// </summary>
        /// <param name="inputArray">The array where the first element should be processed.</param>
        /// <param name="operationType">The operation type which determines how the passed array will be processed. Available types are: FindLargestValue, FindSmallestValue, FindBiggestDiscrepancy, FindLastValue</param>
        /// <param name="names">The array of strings which will be returned in addition to a decimal.</param>
        /// <returns></returns>
        public static decimal ProcessFirstAccount(string[] inputArray, OperationType operationType, out string[] names)
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

        /// <summary>
        /// Processes all elements in an input array except the first and returns a decimal and an array of strings. The returned decimal depends on the operation type selected.
        /// </summary>
        /// <param name="inputArray">The array where all elements except for the first will be processed.</param>
        /// <param name="assumedSearchedValue">The assumed value of the item we are looking for.</param>
        /// <param name="assumedNames">The assumed array of names that should be returned.</param>
        /// <param name="operationType">The operation type which determines how the passed array will be processed. Available types are: FindLargestValue, FindSmallestValue, FindBiggestDiscrepancy, FindLastValue</param>
        /// <param name="names">The array of strings which will be returned in addition to a decimal.</param>
        /// <returns></returns>
        public static decimal ProcessRemainingAccounts(string[] inputArray, decimal assumedSearchedValue, string[] assumedNames, OperationType operationType, out string[] names)
        {
            decimal searchedBalance = assumedSearchedValue;
            names = assumedNames;

            for (int i = 1; i < inputArray.Length; i++)
            {
                var currentAccount = inputArray[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentBalanceHistory = ArrayOperations.ConvertStringArrayToDecimalArray(currentAccount[1..]);

                switch (operationType)
                {
                    case OperationType.FindLargestValue:
                        var currentHighestBalance = ArrayOperations.FindLargestDecimalInArray(currentBalanceHistory);

                        if (currentHighestBalance > searchedBalance)
                        {
                            names = new[] { currentAccountOwner };
                            searchedBalance = currentHighestBalance;
                        }
                        else if (currentHighestBalance == searchedBalance)
                        {
                            names = ArrayOperations.AppendString(names, currentAccountOwner);
                        }
                        break;

                    case OperationType.FindSmallestValue:
                        var currentLowestBalance = ArrayOperations.FindSmallestDecimalInArray(currentBalanceHistory);

                        if (currentLowestBalance < searchedBalance)
                        {
                            names = new[] { currentAccountOwner };
                            searchedBalance = currentLowestBalance;
                        }
                        else if (currentLowestBalance == searchedBalance)
                        {
                            names = ArrayOperations.AppendString(names, currentAccountOwner);
                        }
                        break;

                    case OperationType.FindBiggestDiscrepancy:
                        var currentBiggestLoss = 0.0m; // It only makes sense to return a value higher than 0 if there are actual transactions proving that

                        if (currentBalanceHistory.Length >= 2) // We only want to calculate loss if there are more than 2 transactions in the individual's balance history
                        {
                            currentBiggestLoss = ArrayOperations.FindLargestDecimalInArray(currentBalanceHistory) - ArrayOperations.FindSmallestDecimalInArray(currentBalanceHistory);
                        }
                        else
                        {
                            continue;
                        }

                        if (currentBiggestLoss > searchedBalance)
                        {
                            searchedBalance = currentBiggestLoss;
                            names = new[] { currentAccountOwner };
                        }
                        else if (currentBiggestLoss == searchedBalance)
                        {
                            names = ArrayOperations.AppendString(names, currentAccountOwner);
                        }

                        break;

                    case OperationType.FindLastValue:
                        var currentBalance = decimal.TryParse(currentAccount[^1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsedBalance) ? parsedBalance : 0.0m;

                        if (currentBalance > searchedBalance)
                        {
                            searchedBalance = currentBalance;
                            names = new[] { currentAccountOwner };
                        }
                        else if (currentBalance == searchedBalance)
                        {
                            names = ArrayOperations.AppendString(names, currentAccountOwner);
                        }

                        break;
                }
            }

            return searchedBalance;
        }
    }
}
