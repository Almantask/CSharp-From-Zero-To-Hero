using System.Globalization;

using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        private const string invalidMessage = "N/A.";
        private const string currencySymbol = "¤";

        private static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo() { NumberDecimalSeparator = "." };

        private static decimal ConvertStringToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Currency, numberFormatInfo, out decimal value);
            return value;
        }

        private static bool ArrayIsValid(string[] inputArray)
        {
            if (inputArray != null && inputArray.Length != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsInputStringValid(string inputString)
        {
            if (string.IsNullOrEmpty(inputString) || string.IsNullOrWhiteSpace(inputString))
            {
                return false;
            }
            return true;
        }

        private static decimal HighestBalanceForSinglePerson(string personAndBalance)
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

        private static bool ArrayIsValidForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            if (ArrayIsValid(balanceList) && balanceList.Length > 2 && ConvertStringToDecimal(balanceList[1]) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static decimal LowestBalanceForSinglePerson(string personAndBalance)
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

        private static decimal TotalBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal totalBalance = decimal.Zero;
            for (int i = 1; i < balanceList.Length; i++)
            {
                totalBalance += ConvertStringToDecimal(balanceList[i]);
            }
            return totalBalance;
        }

        private static string ReturnNameForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            if (IsInputStringValid(balanceList[0]))
            {
                return balanceList[0];
            }
            return invalidMessage;
        }

        private static decimal CurrentBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');
            decimal currentBalance = ConvertStringToDecimal(balanceList[^1]);
            return currentBalance;
        }

        private static decimal CalculateLossForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            decimal previousBallance = ConvertStringToDecimal(balanceList[^2]);
            decimal currentBalance = ConvertStringToDecimal(balanceList[^1]);

            var loss = currentBalance - previousBallance;
            return loss;
        }

        private static bool ArrayElementsAreEqual(decimal[] decimalArray)
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

        private static string FormatStringAndCommas(string[] validPeople)
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

        private static string FormatCurrency(decimal currency, string currencySymbol)
        {
            const char negativeSymbol = '-';
            var formatedCurrency = new StringBuilder();
            if (currency < 0)
            {
                currency *= -1;
                formatedCurrency.Append(negativeSymbol).Append(currencySymbol).Append(currency);
                return formatedCurrency.ToString();
            }

            formatedCurrency.Append(currencySymbol).Append(currency);
            return formatedCurrency.ToString();
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances)) return invalidMessage;

            const string peopleMessage = " had the most money ever. ";
            const string singlePersonMessage = " had the most money ever. ";
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
                    .Append(FormatCurrency(highestBalance, currencySymbol))
                    .Append(".");
                return resultMessage.ToString();
            }
            else
            {
                resultMessage.Clear();

                resultMessage
                    .Append(personWithHighestBalance)
                    .Append(singlePersonMessage)
                    .Append(FormatCurrency(highestBalance, currencySymbol))
                    .Append(".");

                return resultMessage.ToString();
            }
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances)) return invalidMessage;

            const string peopleMessage = " lost the most money. ";
            const string singlePersonMessage = " lost the most money. ";
            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];
            var biggestLossList = new decimal[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                if (!ArrayIsValidForSinglePerson(peopleAndBalances[i])) return invalidMessage;
                biggestLossList[i] = CalculateLossForSinglePerson(peopleAndBalances[i]);
            }

            if (biggestLossList.Length > 2 && ArrayElementsAreEqual(biggestLossList))
            {
                resultMessage
                    .Append(invalidMessage);
                return resultMessage.ToString();
            }

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                peopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var biggestLoss = biggestLossList[0];
            var personWithBiggestLoss = peopleList[0];

            for (int i = 0; i < biggestLossList.Length; i++)
            {
                if (biggestLossList[i] < biggestLoss)
                {
                    biggestLoss = biggestLossList[i];
                    personWithBiggestLoss = peopleList[i];
                }
            }

            resultMessage.Clear();

            resultMessage
                .Append(personWithBiggestLoss)
                .Append(singlePersonMessage)
                .Append(FormatCurrency(biggestLoss, currencySymbol))
                .Append(".");

            return resultMessage.ToString();
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances)) return invalidMessage;

            return "";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances)) return invalidMessage;

            const string peopleMessage = " are the richest person. ";
            const string singlePersonMessage = " is the richest person. ";

            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];

            return "";
        }
    }
}