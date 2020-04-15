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

            var firstAccount = peopleAndBalances[0].Split(',');
            var accountOwner = firstAccount[0];
            var accountBalance = ArrayOperations.ConvertStringArrayToDecimalArray(firstAccount);
            var highestBalanceEver = ArrayOperations.FindLargestDecimalInArray(accountBalance); // We assume that the first array/account has the highest balance ever

            var individualsWithHighestBalanceEver = new[] { accountOwner }; // We store the name of the first individual

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentAccountBalance = ArrayOperations.ConvertStringArrayToDecimalArray(currentAccount);
                var currentHighestBalance = ArrayOperations.FindLargestDecimalInArray(currentAccountBalance);

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
    }
}
