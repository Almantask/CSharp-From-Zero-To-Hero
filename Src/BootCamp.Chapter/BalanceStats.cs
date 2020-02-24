using System;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private readonly string[] _peopleAndBalances;
        private readonly string _currency;
        private readonly int _arrayBreak = 2;

        public BalanceStats(string[] peopleAndBalances, string currency)
        {
            _peopleAndBalances = peopleAndBalances;
            _currency = currency;
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public string FindHighestBalanceEver()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return Messages.InvalidMessage;
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

            return AccountOps.AreBalancesEqual(accounts)
                ? $"{StringOps.FormatAndCommas(accounts)} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}."
                : $"{highestBalanceAccount.GetName()} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public string FindPersonWithBiggestLoss()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return Messages.InvalidMessage;
            }

            Account[] accounts = AccountOps.BuildAccountList(_peopleAndBalances);
            for (int i = 0; i < accounts.Length; i++)
            {
                if (i < _arrayBreak && accounts[i].GetTotalBalance() == accounts[i].GetCurrentBalance())
                {
                    return Messages.InvalidMessage;
                }
            }

            Account biggestLossAccount = accounts[0];
            try
            {
                for (int i = 0; i < accounts.Length; i++)
                {
                    if (accounts[i].GetLoss() < biggestLossAccount.GetLoss())
                    {
                        biggestLossAccount = accounts[i];
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                return Messages.InvalidMessage;
            }

            return accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(accounts)
                ? $"{Messages.InvalidMessage}"
                : $"{biggestLossAccount.GetName()} {Messages.LostTheMostMoney}. {StringOps.FormatCurrency(biggestLossAccount.GetLoss(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public string FindRichestPerson()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return Messages.InvalidMessage;
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

            return accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(accounts)
                ? $"{StringOps.FormatAndCommas(accounts)} {Messages.AreTheRichestPeople}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}."
                : $"{richestBalanceAccount.GetName()} {Messages.IsTheRichestPerson}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public string FindMostPoorPerson()
        {
            if (!ArrayOps.IsArrayValid(_peopleAndBalances))
            {
                return Messages.InvalidMessage;
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

            return accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(accounts)
                ? $"{StringOps.FormatAndCommas(accounts)} {Messages.HaveTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}."
                : $"{poorestBalanceAccount.GetName()} {Messages.HasTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }
    }
}