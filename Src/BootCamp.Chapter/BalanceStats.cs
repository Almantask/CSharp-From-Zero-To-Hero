using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public static class BalanceStats
    {
        
        private static string ErrorCode = "N/A";
        private static decimal InitialBalance = 0m;
        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            if (ArrayOperations.IsArrayNullOrEmpty(peopleAndBalances)) return ErrorCode;

            var highestBalanceEver = InitialBalance;

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
                        0
                        );
                }
                else if  (highestBalanceForPerson > highestBalanceEver)
                {
                    peopleWithHighestBalanceEver = new string[] {currentPerson};
                    highestBalanceEver = highestBalanceForPerson;   
                }
            }
            //TODO build helper function to print string array of people with the highest balance
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
