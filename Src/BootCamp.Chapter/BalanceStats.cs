using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        
        private static string codeNotApplicable = "N/A.";
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return codeNotApplicable;

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
            
            return StringOperations.FormatHighestBalanceMessage(peopleWithHighestBalanceEver, highestBalanceEver);

        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return codeNotApplicable;

            var biggestLossOverall = decimal.MaxValue;
            var peopleWithBiggestLossOverall = new string[0];

            foreach (var personAndBalances in peopleAndBalances)
            {
                var nameAndBalances = personAndBalances.Split(
                    "" +
                    ", ",
                    StringSplitOptions.RemoveEmptyEntries
                );
                var currentPerson = nameAndBalances[0];
                var balances = ArrayOperations.ConvertStrArrayToDecimalArray(nameAndBalances[1..]);
                if (balances.Length == 1) return codeNotApplicable;
                var highestBalance = ArrayOperations.FindHighestBalanceIn(balances);
                var lowestBalance = ArrayOperations.FindLowestBalanceIn(balances);
                var overallLossForPerson = lowestBalance - highestBalance;

                if (DecimalOperations.IsAEquivalentToB(overallLossForPerson, biggestLossOverall))
                {
                    peopleWithBiggestLossOverall = ArrayOperations.InsertAt(
                        peopleWithBiggestLossOverall,
                        currentPerson,
                        peopleWithBiggestLossOverall.Length
                    );
                }
                else if (overallLossForPerson < biggestLossOverall)
                {
                    peopleWithBiggestLossOverall = new string[] {currentPerson};
                    biggestLossOverall = overallLossForPerson;
                }
            }

            return StringOperations.FormatBiggestLossMessage(peopleWithBiggestLossOverall, biggestLossOverall);
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return codeNotApplicable;

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
                var lastBalanceForPerson = balances[^1];
                if (DecimalOperations.IsAEquivalentToB(lastBalanceForPerson, highestBalanceAtEnd))
                {
                    peopleWithHighestBalanceAtEnd = ArrayOperations.InsertAt(
                        peopleWithHighestBalanceAtEnd, 
                        currentPerson,
                        peopleWithHighestBalanceAtEnd.Length
                    );
                }
                else if  (lastBalanceForPerson > highestBalanceAtEnd)
                {
                    peopleWithHighestBalanceAtEnd = new string[] {currentPerson};
                    highestBalanceAtEnd = lastBalanceForPerson;   
                }
            }
            
            return StringOperations.FormatRichestPersonMessage(peopleWithHighestBalanceAtEnd, highestBalanceAtEnd);

        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return codeNotApplicable;

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
                var lastBalanceForPerson = balances[^1];
                if (DecimalOperations.IsAEquivalentToB(lastBalanceForPerson, lowestBalanceAtEnd))
                {
                    peopleWithLowestBalanceAtEnd = ArrayOperations.InsertAt(
                        peopleWithLowestBalanceAtEnd, 
                        currentPerson,
                        peopleWithLowestBalanceAtEnd.Length
                    );
                }
                else if  (lastBalanceForPerson < lowestBalanceAtEnd)
                {
                    peopleWithLowestBalanceAtEnd = new string[] {currentPerson};
                    lowestBalanceAtEnd = lastBalanceForPerson;   
                }
            }

            return StringOperations.FormatPoorestPersonMessage(peopleWithLowestBalanceAtEnd, lowestBalanceAtEnd);

        }
    }
}
