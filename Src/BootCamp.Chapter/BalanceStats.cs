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

            var highestBalanceEver = AccountProcessor.ProcessFirstAccount(peopleAndBalances, OperationType.FindLargestValue, out string[] name);
            var individualsWithHighestBalanceEver = name;

            highestBalanceEver = AccountProcessor.ProcessRemainingAccounts(peopleAndBalances, highestBalanceEver, individualsWithHighestBalanceEver, OperationType.FindLargestValue, out string[] names);
            individualsWithHighestBalanceEver = names;

            return $"{ArrayOperations.FormatArrayToString(individualsWithHighestBalanceEver)} had the most money ever. ¤{highestBalanceEver}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances))
                return "N/A.";

            var biggestLoss = AccountProcessor.ProcessFirstAccount(peopleAndBalances, OperationType.FindBiggestDiscrepancy, out string[] name);
            var individualWithBiggestLoss = name;

            biggestLoss = AccountProcessor.ProcessRemainingAccounts(peopleAndBalances, biggestLoss, individualWithBiggestLoss, OperationType.FindBiggestDiscrepancy, out string[] names);
            individualWithBiggestLoss = names;

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

            var highestBalance = AccountProcessor.ProcessFirstAccount(peopleAndBalances, OperationType.FindLastValue, out string[] name);
            var richestIndividuals = name;

            highestBalance = AccountProcessor.ProcessRemainingAccounts(peopleAndBalances, highestBalance, richestIndividuals, OperationType.FindLastValue, out string[] names);
            richestIndividuals = names;

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

            var lowestBalanceEver = AccountProcessor.ProcessFirstAccount(peopleAndBalances, OperationType.FindSmallestValue, out string[] name);
            var individualsWithLowestBalance = name;

            lowestBalanceEver = AccountProcessor.ProcessRemainingAccounts(peopleAndBalances, lowestBalanceEver, individualsWithLowestBalance, OperationType.FindSmallestValue, out string[] names);
            individualsWithLowestBalance = names;

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