using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        
        private static string ErrorCode = "N/A.";
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return ErrorCode;

            var highestBalanceEver = decimal.MinValue;
            var peopleWithHighestBalanceEver = new string[0];
            
            foreach (var  personAndBalances in peopleAndBalances)
            {
                var nameAndBalances = personAndBalances.Split(
                    "" +
                    ", ",
                    StringSplitOptions.RemoveEmptyEntries
                    );
                var currentPerson = nameAndBalances[0];
                var balances = ArrayOperations.ConvertStrArrayToDecimalArray(nameAndBalances[1..]);
                var highestBalanceForPerson = ArrayOperations.FindHighestBalanceIn(balances);
                if (DecimalOperations.IsAEquivalentToB(highestBalanceForPerson, highestBalanceEver))
                {
                    peopleWithHighestBalanceEver = ArrayOperations.InsertAt(
                        peopleWithHighestBalanceEver, 
                        currentPerson,
                        peopleWithHighestBalanceEver.Length
                        );
                }
                else if  (highestBalanceForPerson > highestBalanceEver)
                {
                    peopleWithHighestBalanceEver = new string[] {currentPerson};
                    highestBalanceEver = highestBalanceForPerson;   
                }
            }
            
            var cultureInfo = new CultureInfo("");
            cultureInfo.NumberFormat.CurrencyGroupSeparator = "";
            return $"{ArrayOperations.FormatToString(peopleWithHighestBalanceEver)} had the most money ever. "  +
                   $"{highestBalanceEver.ToString("C0", cultureInfo)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return ErrorCode;

            return "";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return ErrorCode;

            var highestBalanceAtEnd = decimal.MinValue;

            var peopleWithHighestBalanceAtEnd = new string[0];
            
            foreach (var  personAndBalances in peopleAndBalances)
            {
                var nameAndBalances = personAndBalances.Split(
                    "" +
                    ", ",
                    StringSplitOptions.RemoveEmptyEntries
                );
                var currentPerson = nameAndBalances[0];
                var balances = ArrayOperations.ConvertStrArrayToDecimalArray(nameAndBalances[1..]);
                var highestBalanceAtEndForPerson = balances[^1];
                if (DecimalOperations.IsAEquivalentToB(highestBalanceAtEndForPerson, highestBalanceAtEnd))
                {
                    peopleWithHighestBalanceAtEnd = ArrayOperations.InsertAt(
                        peopleWithHighestBalanceAtEnd, 
                        currentPerson,
                        peopleWithHighestBalanceAtEnd.Length
                    );
                }
                else if  (highestBalanceAtEndForPerson > highestBalanceAtEnd)
                {
                    peopleWithHighestBalanceAtEnd = new string[] {currentPerson};
                    highestBalanceAtEnd = highestBalanceAtEndForPerson;   
                }
            }
            
            var cultureInfo = new CultureInfo("");
            cultureInfo.NumberFormat.CurrencyGroupSeparator = "";
            return $"{ArrayOperations.FormatToString(peopleWithHighestBalanceAtEnd)} " +
                   $"{StringOperations.PluralizeIsByCount(peopleWithHighestBalanceAtEnd.Length)} the richest " +
                   $"{StringOperations.PluralizePersonByCount(peopleWithHighestBalanceAtEnd.Length)}. "  +
                   $"{highestBalanceAtEnd.ToString("C0", cultureInfo)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return ErrorCode;

            var lowestBalanceAtEnd = decimal.MaxValue;
            var peopleWithLowestBalanceAtEnd = new string[0];
            
            foreach (var  personAndBalances in peopleAndBalances)
            {
                var nameAndBalances = personAndBalances.Split(
                    "" +
                    ", ",
                    StringSplitOptions.RemoveEmptyEntries
                );
                var currentPerson = nameAndBalances[0];
                var balances = ArrayOperations.ConvertStrArrayToDecimalArray(nameAndBalances[1..]);
                var lowestBalanceAtEndForPerson = balances[^1];
                if (DecimalOperations.IsAEquivalentToB(lowestBalanceAtEndForPerson, lowestBalanceAtEnd))
                {
                    peopleWithLowestBalanceAtEnd = ArrayOperations.InsertAt(
                        peopleWithLowestBalanceAtEnd, 
                        currentPerson,
                        peopleWithLowestBalanceAtEnd.Length
                    );
                }
                else if  (lowestBalanceAtEndForPerson < lowestBalanceAtEnd)
                {
                    peopleWithLowestBalanceAtEnd = new string[] {currentPerson};
                    lowestBalanceAtEnd = lowestBalanceAtEndForPerson;   
                }
            }

            var cultureInfo = new CultureInfo("");
            cultureInfo.NumberFormat.CurrencyGroupSeparator = "";
            cultureInfo.NumberFormat.CurrencyNegativePattern = 1;
            return $"{ArrayOperations.FormatToString(peopleWithLowestBalanceAtEnd)} " +
                   $"{StringOperations.PluralizeHasByCount(peopleWithLowestBalanceAtEnd.Length)} the least money. " +
                   $"{lowestBalanceAtEnd.ToString("C0", cultureInfo)}.";
        }
    }
}
