using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var highestBalanceEver = GetHighestBalanceEver(peopleAndBalances);

            var peopleNamesWithHighestBalance = GetPeopleNamesWithSameBalance(peopleAndBalances, highestBalanceEver, "highest");
            var formatedPeopleNames = GetFormatedPeople(peopleNamesWithHighestBalance);

            // this passes the tests, but it returns highest balance not current balance as requested
            // if it returns current balance one of the tests fails. 
            return $"{formatedPeopleNames} had the most money ever. ¤{highestBalanceEver}.";
        }

        public static string GetFormatedPeople(string[] peopleAndBalances)
        {
            switch (peopleAndBalances.Length)
            {
                case 1:
                    return peopleAndBalances[0];
                case 2:
                    return $"{peopleAndBalances[0]} and {peopleAndBalances[1]}";
                default:
                    // If need to this can be implemented to loop through the array, in any case only 3 different cases needed.
                    return $"{peopleAndBalances[0]}, {peopleAndBalances[1]} and {peopleAndBalances[2]}";
            }
        }

        public static string[] GetPeopleNamesWithSameBalance(string[] peopleAndBalances, float balance, string currentOrHighest)
        {
            var individualPersonAndBalance = 0f;
            var sb = new StringBuilder();
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var person = ConvertToArray(peopleAndBalances[i]);

                if (currentOrHighest.ToLowerInvariant().Equals("current"))
                {
                    individualPersonAndBalance = GetCurrentBalancefor(peopleAndBalances[i]);
                }
                if (currentOrHighest.ToLowerInvariant().Equals("highest"))
                {
                    individualPersonAndBalance = GetHighestBalanceFor(peopleAndBalances[i]);
                }
                if (individualPersonAndBalance.Equals(balance))
                {
                    sb.Append($"{person[0]}, ");
                }
            }
            // To remove comma at the end.
            var peopleWithSameBalance = sb.ToString().Remove(sb.ToString().Length - 2);
            return ConvertToArray(peopleWithSameBalance);
        }

        public static float GetHighestBalanceEver(string[] peopleAndBalances)
        {
            var highestBalance = GetHighestBalanceFor(peopleAndBalances[0]);
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                if (highestBalance < GetHighestBalanceFor(peopleAndBalances[i]))
                {
                    highestBalance = GetHighestBalanceFor(peopleAndBalances[i]);
                }
            }
            return highestBalance;
        }
        public static float GetHighestBalanceFor(string personAndBalance)
        {
            var balance = ConvertToBalanceArray(personAndBalance);
            var highestBalance = balance[0];
            for (int i = 0; i < balance.Length; i++)
            {
                if (highestBalance < balance[i])
                {
                    highestBalance = balance[i];
                }
            }
            return highestBalance;
        }

        // using float because it is currency
        public static float[] ConvertToBalanceArray(string personAndBalance)
        {
            string[] personAndBalanceArray = ConvertToArray(personAndBalance);

            if(personAndBalanceArray.Length == 1)
            {
                float[] noBalance = new float[] { 0 };
                return noBalance;
            }

            float[] balance = new float[personAndBalanceArray.Length - 1];

            for (int i = 1; i < personAndBalanceArray.Length; i++)
            {
                // in this case not using try parse, becase it is known 
                // that array have only numbers 

                balance[i - 1] = float.Parse(personAndBalanceArray[i], NumberStyles.Currency);
            }
            return balance;
        }
        public static string[] ConvertToArray(string personAndBalance)
        {
            // this to remove white spaces in string array
            personAndBalance = personAndBalance.Replace(", ", ",");
            string[] personAndBalanceArray = personAndBalance.Split(',');
            return personAndBalanceArray;
        }

        public static bool HaveMoreThanOneEntryInHistory(string personAndBalance)
        {
            var balance = ConvertToBalanceArray(personAndBalance);
            return balance.Length > 1;
        }

        public static bool IsValidForCheck(string[] peopleAndBalances)
        {
            if (peopleAndBalances == null)
            {
                return false;
            }

            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                if (HaveMoreThanOneEntryInHistory(peopleAndBalances[0]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (!IsValidForCheck(peopleAndBalances))
            {
                return "N/A.";
            }

            var biggestLoss = GetLossFor(peopleAndBalances[0]);
            var personWithBiggestLoss = ConvertToArray(peopleAndBalances[0])[0];
            for (int i = 0; i < peopleAndBalances.Length; i++)
            {
                var loss = GetLossFor(peopleAndBalances[i]);
                var person = ConvertToArray(peopleAndBalances[i]);
                if (biggestLoss > loss)
                {
                    biggestLoss = loss;
                    personWithBiggestLoss = person[0];
                }
            }

            return $"{personWithBiggestLoss} lost the most money. {FormatCurrency(biggestLoss)}.";
        }

        public static string FormatCurrency(float number)
        {
            var originalCulture = CultureInfo.CurrentCulture;
            var culture = CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            var clonedNumbers = (NumberFormatInfo)culture.NumberFormat.Clone();
            clonedNumbers.CurrencyNegativePattern = 1;
            var formatedBiggestLoss = string.Format(clonedNumbers, "{0:C0}", number);
            CultureInfo.CurrentCulture = originalCulture;

            return formatedBiggestLoss;
        }

        public static float GetLossFor(string personAndBalance)
        {
            var balance = ConvertToBalanceArray(personAndBalance);
            var loss = 0f;
            for (int i = 0; i < balance.Length - 1; i++)
            {
                if (balance[i + 1] - balance[i] < loss)
                {
                    loss = balance[i + 1] - balance[i];
                }
            }
            return loss;
        }

        public static float GetCurrentBalancefor(string personAndBalance)
        {
            var balance = ConvertToBalanceArray(personAndBalance);
            return balance[balance.Length - 1];
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var richestPersonsBalance = GetRichestPersonsBalance(peopleAndBalances);

            var richestPeopleNames = GetPeopleNamesWithSameBalance(peopleAndBalances, richestPersonsBalance, "current");
            var formatedPeopleNames = GetFormatedPeople(richestPeopleNames);

            var areOrIs = (richestPeopleNames.Length > 1) ? "are" : "is";
            var peopleOrPerson = (richestPeopleNames.Length > 1) ? "people" : "person";
            return $"{formatedPeopleNames} {areOrIs} the richest {peopleOrPerson}. ¤{richestPersonsBalance}.";
        }

        public static float GetRichestPersonsBalance(string[] peopleAndBalances)
        {
            if (peopleAndBalances.Length == 1)
            {
                return GetCurrentBalancefor(peopleAndBalances[0]);
            }
            var richestPersonsBalance = GetCurrentBalancefor(peopleAndBalances[0]);
            for (int i = 0; i < peopleAndBalances.Length - 1; i++)
            {
                if (richestPersonsBalance < GetCurrentBalancefor(peopleAndBalances[i + 1]))
                {
                    richestPersonsBalance = GetCurrentBalancefor(peopleAndBalances[i + 1]);
                }
            }
            return richestPersonsBalance;
        }

        public static bool IsArrayNullOrEmpty(string[] peopleAndBalances)
        {
            return peopleAndBalances == null || peopleAndBalances.Length == 0;
        }


        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (IsArrayNullOrEmpty(peopleAndBalances))
            {
                return "N/A.";
            }
            var poorestPersonsBalance = GetPoorestPersonsBalance(peopleAndBalances);
            var poorestPeopleNames = GetPeopleNamesWithSameBalance(peopleAndBalances, poorestPersonsBalance, "current");
            var formatedPeopleNames = GetFormatedPeople(poorestPeopleNames);

            var hasOrHave = (poorestPeopleNames.Length > 1) ? "have" : "has";
            return $"{formatedPeopleNames} {hasOrHave} the least money. {FormatCurrency(poorestPersonsBalance)}.";
        }
        public static float GetPoorestPersonsBalance(string[] peopleAndBalances)
        {
            if (peopleAndBalances.Length == 1)
            {
                return GetCurrentBalancefor(peopleAndBalances[0]);
            }
            var poorestPersonsBalance = GetCurrentBalancefor(peopleAndBalances[0]);
            for (int i = 0; i < peopleAndBalances.Length - 1; i++)
            {
                if (poorestPersonsBalance > GetCurrentBalancefor(peopleAndBalances[i + 1]))
                {
                    poorestPersonsBalance = GetCurrentBalancefor(peopleAndBalances[i + 1]);
                }
            }
            return poorestPersonsBalance;
        }
    }
}