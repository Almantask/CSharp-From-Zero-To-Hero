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
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i].GetHighestBalance() > highestBalanceAccount.GetHighestBalance())
                {
                    highestBalanceAccount = accounts[i];
                }
            }

            if (AccountOps.AreAccountsBallancesEqual(accounts))
            {
                return $"{StringOps.FormatAndCommas(accounts)} {StringOps.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), currency)}.";
            }
            else
            {
                return $"{highestBalanceAccount.GetName()} {StringOps.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), currency)}.";
            }
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public string FindPersonWithBiggestLoss()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return StringOps.InvalidMessage;
            }

            Account[] accounts = AccountOps.BuildAccountList(_peopleAndBalances);
            for (int i = 0; i < accounts.Length; i++)
            {
                if (i < arrayBreak && accounts[i].GetTotalBalance() == accounts[i].GetCurrentBalance())
                {
                    return StringOps.InvalidMessage;
                }
            }

            Account biggestLossAccount = accounts[0];
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i].GetLoss() < biggestLossAccount.GetLoss())
                {
                    biggestLossAccount = accounts[i];
                }
            }

            if (accounts.Length > arrayBreak && AccountOps.AreAccountsBallancesEqual(accounts))
            {
                return $"{StringOps.InvalidMessage}";
            }
            else
            {
                return $"{biggestLossAccount.GetName()} {StringOps.LostTheMostMoney}. {StringOps.FormatCurrency(biggestLossAccount.GetLoss(), currency)}.";
            }
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public string FindRichestPerson()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return StringOps.InvalidMessage;
            }

            Account[] accounts = AccountOps.BuildAccountList(_peopleAndBalances);

            Account richestBalanceAccount = accounts[0];
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i].GetCurrentBalance() > richestBalanceAccount.GetCurrentBalance())
                {
                    richestBalanceAccount = accounts[i];
                }
            }

            if (accounts.Length > arrayBreak && AccountOps.AreAccountsBallancesEqual(accounts))
            {
                return $"{StringOps.FormatAndCommas(accounts)} {StringOps.AreTheRichestPeople}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), currency)}.";
            }
            else
            {
                return $"{richestBalanceAccount.GetName()} {StringOps.IsTheRichestPerson}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), currency)}.";
            }
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public string FindMostPoorPerson()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return StringOps.InvalidMessage;
            }

            Account[] accounts = AccountOps.BuildAccountList(_peopleAndBalances);

            Account poorestBalanceAccount = accounts[0];
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i].GetCurrentBalance() < poorestBalanceAccount.GetCurrentBalance())
                {
                    poorestBalanceAccount = accounts[i];
                }
            }

            if (accounts.Length > arrayBreak && AccountOps.AreAccountsBallancesEqual(accounts))
            {
                return $"{StringOps.FormatAndCommas(accounts)} {StringOps.HaveTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), currency)}.";
            }
            else
            {
                return $"{poorestBalanceAccount.GetName()} {StringOps.HasTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), currency)}.";
            }
        }
    }
}