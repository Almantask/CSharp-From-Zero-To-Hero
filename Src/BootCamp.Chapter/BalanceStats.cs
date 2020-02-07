using System.Globalization;
using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = "." };
        private const string invalidMessage = "N/A.";
        private const string currencySymbol = " ¤";

        private static decimal ConvertStringToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Any, numberFormatInfo, out decimal value);
            return value;
        }

        private static bool IsArrayValid(string[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                return false;
            }
            return true;
        }

        private static bool IsInputStringValid(string inputString)
        {
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
            {
                return false;
            }
            return true;
        }

        public static decimal HighestBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal highestBalance = ConvertStringToDecimal(balanceList[1]);

            for (int i = 1; i < balanceList.Length; i++)
            {
                if (ConvertStringToDecimal(balanceList[i]) > highestBalance)
                {
                    highestBalance = ConvertStringToDecimal(balanceList[i]);
                }
            }
            return highestBalance;
        }

        public static decimal LowestBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal lowestBalance = ConvertStringToDecimal(balanceList[1]);

            for (int i = 1; i < balanceList.Length; i++)
            {
                if (ConvertStringToDecimal(balanceList[i]) < lowestBalance)
                {
                    lowestBalance = ConvertStringToDecimal(balanceList[i]);
                }
            }
            return lowestBalance;
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

        public static string ReturnNameForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            if (IsInputStringValid(balanceList[0]))
            {
                return balanceList[0];
            }
            return invalidMessage;
        }

        public static decimal CalculateLossForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            decimal previousBalance = ConvertStringToDecimal(balanceList[1]);
            decimal currentBalance = ConvertStringToDecimal(balanceList[^1]);

            for (int i = 2; i < balanceList.Length - 1; i++)
            {
                previousBalance += ConvertStringToDecimal(balanceList[i]);
            }
            return currentBalance - previousBalance;
        }

        public static bool ArrayElementsAreEqual(decimal[] decimalArray)
        {
            decimal firstElement = decimalArray[0];
            for (int i = 0; i < decimalArray.Length; i++)
            {
                if (decimalArray[i] != firstElement)
                {
                    return false;
                }
            }
            return true;
        }

        public static string FormatStringAndCommas(string[] validPeople)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < validPeople.Length; i++)
            {
                sb.Append(validPeople[i]);
                if (i + 2 < validPeople.Length)
                {
                    sb.Append(", ");
                }
                else if (i + 1 < validPeople.Length)
                {
                    sb.Append(" and ");
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (!IsArrayValid(peopleAndBalances)) return invalidMessage;

            const string peopleMessage = " had the most money ever.";
            const string singlePersonMessage = " had the most money ever.";
            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];
            var highestList = new decimal[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                highestList[i] = HighestBalanceForSinglePerson(peopleAndBalances[i]);
            }
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var highestBalance = highestList[0];
            var personWithHighestBalance = peopleList[0];

            for (int i = 1; i < highestList.Length; i++)
            {
                if (highestList[i] > highestBalance)
                {
                    highestBalance = highestList[i];
                    personWithHighestBalance = peopleList[i];
                }
            }

            if (ArrayElementsAreEqual(highestList))
            {
                resultMessage
                    .Append(FormatStringAndCommas(peopleList))
                    .Append(peopleMessage)
                    .Append(currencySymbol)
                    .Append(highestBalance)
                    .Append(".");
                return resultMessage.ToString();
            }
            resultMessage.Clear();

            resultMessage
                .Append(personWithHighestBalance)
                .Append(singlePersonMessage)
                .Append(currencySymbol)
                .Append(highestBalance)
                .Append(".");

            return resultMessage.ToString();
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!IsArrayValid(peopleAndBalances)) return invalidMessage;

            const string peopleMessage = " lost the most money.";
            const string singlePersonMessage = " lost the most money.";
            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];
            var lowestList = new decimal[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                lowestList[i] = CalculateLossForSinglePerson(peopleAndBalances[i]);
                peopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var initialBalance = lowestList[0];
            var personWithLowestBalance = peopleList[0];

            for (int i = 1; i < lowestList.Length; i++)
            {
                if (lowestList[i] < initialBalance)
                {
                    initialBalance = lowestList[i];
                    personWithLowestBalance = peopleList[i];
                }
            }

            if (ArrayElementsAreEqual(lowestList) || lowestList.Length < 2)
            {
                resultMessage.Append(invalidMessage);
                return resultMessage.ToString();
            }
            resultMessage.Clear();

            resultMessage.Append(personWithLowestBalance)
                         .Append(singlePersonMessage)
                         .Append(currencySymbol)
                         .Append(initialBalance)
                         .Append(".");
            return resultMessage.ToString();
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