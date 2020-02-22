using System;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private readonly string[] _peopleAndBalances;
        private const string currency = "\u00A4";
        private const int arrayBreak = 2;

        public BalanceStats(string[] peopleAndBalances)
        {
            _peopleAndBalances = peopleAndBalances;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public string FindHighestBalanceEver()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return StringOps.InvalidMessage;
            }

            Account[] accounts = AccountOps.BuildAccountList(_peopleAndBalances);

            Account highestBalanceAccount = accounts[0];
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].GetHighestBalance() > highestBalanceAccount.GetHighestBalance())
                {
                    highestBalanceAccount = accounts[i];
                }
            }

            string result;
            if (AccountOps.AreAccountsBallancesEqual(accounts))
            {
                result = $"{StringOps.FormatAndCommas(accounts)} {StringOps.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), currency)}";
            }
            else
            {
                result = $"{highestBalanceAccount.GetName()} {StringOps.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), currency)}.";
            }

            return result;
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
