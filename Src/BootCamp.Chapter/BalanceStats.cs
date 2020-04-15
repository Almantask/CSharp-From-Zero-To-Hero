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
            if (peopleAndBalances == null || peopleAndBalances.Length == 0) // ToDo: Implement validation function to make sure it's reusable in other functions as well
            {
                return "N/A.";
            }

            var firstAccount = peopleAndBalances[0].Split(',');
            var accountOwner = firstAccount[0];
            var accountBalance = ConvertStringArrayToDecimalArray(firstAccount);
            var highestBalanceEver = FindLargestDecimalInArray(accountBalance); // We assume that the first array/account has the highest balance ever

            var individualsWithHighestBalanceEver = new[] { accountOwner }; // We store the name of the first individual

            for (int i = 1; i < peopleAndBalances.Length; i++)
            {
                var currentAccount = peopleAndBalances[i].Split(',');
                var currentAccountOwner = currentAccount[0];
                var currentAccountBalance = ConvertStringArrayToDecimalArray(currentAccount);
                var currentHighestBalance = FindLargestDecimalInArray(currentAccountBalance);

                if (currentHighestBalance > highestBalanceEver)
                {
                    individualsWithHighestBalanceEver = new[] { currentAccountOwner };
                    highestBalanceEver = currentHighestBalance;
                } 
                else if (currentHighestBalance == highestBalanceEver)
                {
                    individualsWithHighestBalanceEver = AppendString(individualsWithHighestBalanceEver, currentAccount[0]);
                }
            }

            return $"{FormatArrayToString(individualsWithHighestBalanceEver)} had the most money ever. ¤{highestBalanceEver}.";
        }

        private static decimal[] ConvertStringArrayToDecimalArray(string[] array)
        {
            var decimalArray = new decimal[array.Length];

            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = decimal.TryParse(array[i], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed) ? parsed : 0.0m;
            }

            return decimalArray;
        }

        private static decimal FindLargestDecimalInArray(decimal[] array)
        {
            var currentHighestDecimal = array[0]; //We assume the first value to be the largest decimal in the array

            for (int i = 1; i < array.Length; i++)
            {
                if (currentHighestDecimal < array[i])
                {
                    currentHighestDecimal = array[i];
                }
            }

            return currentHighestDecimal;
        }

        private static string FormatArrayToString(string[] array)
        {
            if (array.Length == 1)
            {
                return array[0];
            }

            var formattedString = string.Join(", ", array[..^1]);
            formattedString += $" and {array[^1]}";

            return formattedString;
        }

        private static string[] AppendString(string[] array, string stringToAppend)
        {
            var returnArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                returnArray[i] = array[i];
            }
            returnArray[^1] = stringToAppend;
            return returnArray;
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
