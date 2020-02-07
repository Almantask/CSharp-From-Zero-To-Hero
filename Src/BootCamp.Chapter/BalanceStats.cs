using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = "." };
        private const string invalidMessage = "N/A.";

        private static decimal ConvertStringToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Any, numberFormatInfo, out decimal value);
            return value;
        }

        public static decimal HighestBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal maxBalance = ConvertStringToDecimal(balanceList[1]);

            for (int i = 1; i < balanceList.Length; i++)
            {
                if (ConvertStringToDecimal(balanceList[i]) > maxBalance)
                {
                    maxBalance = ConvertStringToDecimal(balanceList[i]);
                }
            }
            return maxBalance;
        }

        public static decimal TotalBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal totalBalance = decimal.Zero;
            for (int i = 1; i < balanceList.Length; i++)
            {
                totalBalance += ConvertStringToDecimal(balanceList[i]);
            }
            return totalBalance;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            return "";
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