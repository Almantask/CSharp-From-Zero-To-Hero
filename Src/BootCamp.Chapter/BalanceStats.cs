using System.Globalization;
using System.Text;
using System;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        public static string DefaultCurrencySymbol { get; set; } = "¤";

        public static int DefaultCurrencyLocation { get; set; }

        private const string invalidMessage = "N/A.";
        private const string messageEnd = ".";
        private const int arrayBreakLength = 2;
        private static readonly NumberFormatInfo numberFormatInfo = new NumberFormatInfo { NumberDecimalSeparator = "." };

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances))
            {
                return invalidMessage;
            }

            const string peopleMessage = " had the most money ever. ";
            const string singlePersonMessage = " had the most money ever. ";

            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];
            var highestBalanceList = new decimal[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                highestBalanceList[i] = HighestBalanceForSinglePerson(peopleAndBalances[i]);
                peopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var highestBalanceIndex = FindDecimalArrayMax(highestBalanceList);
            var highestBalance = highestBalanceList[highestBalanceIndex];
            var personWithHighestBalance = peopleList[highestBalanceIndex];

            if (ArrayElementsAreEqual(highestBalanceList))
            {
                resultMessage
                    .Append(FormatStringAndCommas(peopleList))
                    .Append(peopleMessage)
                    .Append(FormatCurrency(highestBalance))
                    .Append(messageEnd);
                return resultMessage.ToString();
            }
            else
            {
                resultMessage.Clear();

                resultMessage
                    .Append(personWithHighestBalance)
                    .Append(singlePersonMessage)
                    .Append(FormatCurrency(highestBalance))
                    .Append(messageEnd);

                return resultMessage.ToString();
            }
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances))
            {
                return invalidMessage;
            }

            const string peopleMessage = " have the least money. ";
            const string singlePersonMessage = " has the least money. ";

            var resultMessage = new StringBuilder();
            var mostPoorBalanceList = new decimal[peopleAndBalances.Length];
            var mostPoorPeopleList = new string[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                mostPoorBalanceList[i] = CurrentBalanceForSinglePerson(peopleAndBalances[i]);
                mostPoorPeopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var mostPoorPersonsIndex = FindDecimalArrayMin(mostPoorBalanceList);
            var mostPoortPerson = mostPoorPeopleList[mostPoorPersonsIndex];
            var mostPoorPersonsMoney = mostPoorBalanceList[mostPoorPersonsIndex];

            if (mostPoorBalanceList.Length > arrayBreakLength && ArrayElementsAreEqual(mostPoorBalanceList))
            {
                resultMessage
                    .Append(FormatStringAndCommas(mostPoorPeopleList))
                    .Append(peopleMessage)
                    .Append(FormatCurrency(mostPoorPersonsMoney))
                    .Append(messageEnd);
                return resultMessage.ToString();
            }

            resultMessage.Clear();

            resultMessage
                .Append(mostPoortPerson)
                .Append(singlePersonMessage)
                .Append(FormatCurrency(mostPoorPersonsMoney))
                .Append(messageEnd);

            return resultMessage.ToString();
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances))
            {
                return invalidMessage;
            }

            const string singlePersonMessage = " lost the most money. ";
            var resultMessage = new StringBuilder();
            var peopleList = new string[peopleAndBalances.Length];
            var biggestLossList = new decimal[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                if (i < arrayBreakLength && TotalBalanceForSinglePerson(peopleAndBalances[i]) == CurrentBalanceForSinglePerson(peopleAndBalances[i]))
                {
                    return invalidMessage;
                }
            }

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                biggestLossList[i] = CalculateLossForSinglePerson(peopleAndBalances[i]);
                peopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            if (biggestLossList.Length > arrayBreakLength && ArrayElementsAreEqual(biggestLossList))
            {
                resultMessage
                    .Append(invalidMessage);
                return resultMessage.ToString();
            }

            var biggestLossIndex = FindDecimalArrayMin(biggestLossList);

            var biggestLoss = biggestLossList[biggestLossIndex];
            var personWithBiggestLoss = peopleList[biggestLossIndex];

            resultMessage.Clear();
            resultMessage
                .Append(personWithBiggestLoss)
                .Append(singlePersonMessage)
                .Append(FormatCurrency(biggestLoss))
                .Append(messageEnd);

            return resultMessage.ToString();
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (!ArrayIsValid(peopleAndBalances))
            {
                return invalidMessage;
            }

            const string singlePersonMessage = " is the richest person. ";
            const string peopleMessage = " are the richest people. ";

            var resultMessage = new StringBuilder();
            var richPeopleBalanceList = new decimal[peopleAndBalances.Length];
            var richPeopleList = new string[peopleAndBalances.Length];

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                richPeopleBalanceList[i] = CurrentBalanceForSinglePerson(peopleAndBalances[i]);
                richPeopleList[i] = ReturnNameForSinglePerson(peopleAndBalances[i]);
            }

            var richestPersonIndex = FindDecimalArrayMax(richPeopleBalanceList);
            var richestPerson = richPeopleList[richestPersonIndex];
            var richestPersonMoney = richPeopleBalanceList[richestPersonIndex];

            if (richPeopleBalanceList.Length > arrayBreakLength && ArrayElementsAreEqual(richPeopleBalanceList))
            {
                resultMessage
                    .Append(FormatStringAndCommas(richPeopleList))
                    .Append(peopleMessage)
                    .Append(FormatCurrency(richestPersonMoney))
                    .Append(messageEnd);
                return resultMessage.ToString();
            }

            resultMessage.Clear();

            resultMessage
                .Append(richestPerson)
                .Append(singlePersonMessage)
                .Append(FormatCurrency(richestPersonMoney))
                .Append(messageEnd);

            return resultMessage.ToString();
        }

        /// <summary>
        /// Checks all elements of the array for equality.
        /// </summary>
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

        /// <summary>
        /// Verifies if array is valid.
        /// </summary>
        private static bool ArrayIsValid(string[] inputArray)
        {
            return inputArray != null && inputArray.Length != 0;
        }

        /// <summary>
        /// Calculates the loss for a single person in array.
        /// </summary>
        private static decimal CalculateLossForSinglePerson(string personAndBalance)
        {
            var balanceList = ConvertStringToDecimalArray(personAndBalance);

            try
            {
                decimal previousBallance = balanceList[^2];
                decimal currentBalance = balanceList[^1];
                var loss = currentBalance - previousBallance;

                return loss;
            }
            catch (IndexOutOfRangeException)
            {
            }
            return default;
        }

        /// <summary>
        /// Tries to convert a string to decimal.
        /// </summary>
        private static decimal ConvertStringToDecimal(string input)
        {
            decimal.TryParse(input, NumberStyles.Currency, numberFormatInfo, out decimal value);

            return value;
        }

        /// <summary>
        /// Converts the numbers split by comma part of the string to an array.
        /// </summary>
        private static decimal[] ConvertStringToDecimalArray(string personAndBalance)
        {
            if (!InputStringIsValid(personAndBalance))
            {
                return default;
            }

            var array = personAndBalance.Split(',');
            var newArray = new decimal[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                newArray[i - 1] = ConvertStringToDecimal(array[i]);
            }

            return newArray;
        }

        /// <summary>
        /// Finds the current balance of a single person in array.
        /// </summary>
        private static decimal CurrentBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = ConvertStringToDecimalArray(personAndBalance);
            try
            {
                decimal currentBalance = balanceList[^1];

                return currentBalance;
            }
            catch (Exception)
            {
            }
            return default;
        }

        /// <summary>
        /// Return index of Max value in decimal array.
        /// </summary>
        private static int FindDecimalArrayMax(decimal[] inputArray)
        {
            var max = decimal.Zero;
            try
            {
                max = inputArray[0];
            }
            catch (IndexOutOfRangeException)
            {
            }
            var index = 0;
            for (int i = index; i < inputArray.Length; i++)
            {
                if (inputArray[i] > max)
                {
                    max = inputArray[i];
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Return index of Min value in decimal array.
        /// </summary>
        private static int FindDecimalArrayMin(decimal[] inputArray)
        {
            var min = decimal.Zero;

            try
            {
                min = inputArray[0];
            }
            catch (IndexOutOfRangeException)
            {
            }
            var index = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] < min)
                {
                    min = inputArray[i];
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Returns an formated output of currency (ex. -¤1, ¤4, ¤1002, -¤1001).
        /// </summary>
        private static string FormatCurrency(decimal currency)
        {
            const char negativeSymbol = '-';

            var formatedCurrency = new StringBuilder();

            if (currency < 0)
            {
                currency *= -1;
                if (DefaultCurrencyLocation == 0)
                    formatedCurrency.Append(negativeSymbol).Append(DefaultCurrencySymbol).Append(currency);
                if (DefaultCurrencyLocation == 1)
                    formatedCurrency.Append(DefaultCurrencySymbol).Append(" ").Append(negativeSymbol).Append(currency);
                return formatedCurrency.ToString();
            }

            if (DefaultCurrencyLocation == 0)
            {
                formatedCurrency.Append(DefaultCurrencySymbol).Append(currency);
            }

            if (DefaultCurrencyLocation == 1)
            {
                formatedCurrency.Append(DefaultCurrencySymbol).Append(" ").Append(currency);
            }

            return formatedCurrency.ToString();
        }

        /// <summary>
        /// Return formated output for multiple names in array (Kai, EarLington and Mihail).
        /// </summary>
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

        /// <summary>
        /// Finds highest balance for a single person.
        /// </summary>
        private static decimal HighestBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = ConvertStringToDecimalArray(personAndBalance);
            var highestBalanceIndex = FindDecimalArrayMax(balanceList);

            try
            {
                var highestBalance = balanceList[highestBalanceIndex];
                return highestBalance;
            }
            catch (Exception)
            {
            }
            return default;
        }

        /// <summary>
        /// Verifies if string is valid.
        /// </summary>
        private static bool InputStringIsValid(string inputString)
        {
            return !string.IsNullOrEmpty(inputString) && !string.IsNullOrWhiteSpace(inputString);
        }

        /// <summary>
        /// Finds the name of a single person in array.
        /// </summary>
        private static string ReturnNameForSinglePerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            if (InputStringIsValid(balanceList[0]))
            {
                return balanceList[0];
            }

            return invalidMessage;
        }

        /// <summary>
        /// Finds total balance for a single person.
        /// </summary>
        private static decimal TotalBalanceForSinglePerson(string personAndBalance)
        {
            var balanceList = ConvertStringToDecimalArray(personAndBalance);
            decimal totalBalance = decimal.Zero;

            for (int i = 0; i < balanceList.Length; i++)
            {
                totalBalance += balanceList[i];
            }

            return totalBalance;
        }
    }
}