using System;

namespace BootCamp.Chapter
{
    public class BalanceStats
    {
        private readonly string _currency;
        private readonly Account[] _accounts;
        private const int _arrayBreak = 2;

        public BalanceStats(string[] peopleAndBalances)
        {
            _currency = Settings.currency;
            _accounts = AccountOps.BuildAccountList(peopleAndBalances);
        }

        /// <summary>
        /// Return name and balance(current) of person who had the biggest historic balance.
        /// </summary>
        public string FindHighestBalanceEver()
        {
            Account highestBalanceAccount;
            try
            {
                highestBalanceAccount = _accounts[0];
                for (int i = 1; i < _accounts.Length; i++)
                {
                    if (_accounts[i].GetHighestBalance() > highestBalanceAccount.GetHighestBalance())
                    {
                        highestBalanceAccount = _accounts[i];
                    }
                }
            }
            catch (NullReferenceException)
            {
                return Messages.InvalidMessage;
            }
            catch (IndexOutOfRangeException)
            {
                return Messages.InvalidMessage;
            }

            return _accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(_accounts)
              ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}."
              : $"{highestBalanceAccount.GetName()} {Messages.HadTheMostMoneyEver}. {StringOps.FormatCurrency(highestBalanceAccount.GetHighestBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and loss of a person with a biggest loss (balance change negative).
        /// </summary>
        public string FindPersonWithBiggestLoss()
        {
            Account biggestLossAccount;
            try
            {
                biggestLossAccount = _accounts[0];
                for (int i = 0; i < _accounts.Length; i++)
                {
                    if (_accounts[i].GetLoss() < biggestLossAccount.GetLoss())
                    {
                        biggestLossAccount = _accounts[i];
                    }
                }
            }
            catch (NullReferenceException)
            {
                return Messages.InvalidMessage;
            }
            catch (IndexOutOfRangeException)
            {
                return Messages.InvalidMessage;
            }

            return _accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(_accounts)
                ? $"{Messages.InvalidMessage}"
                : $"{biggestLossAccount.GetName()} {Messages.LostTheMostMoney}. {StringOps.FormatCurrency(biggestLossAccount.GetLoss(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the richest person.
        /// </summary>
        public string FindRichestPerson()
        {
            Account richestBalanceAccount;
            try
            {
                richestBalanceAccount = _accounts[0];
                for (int i = 1; i < _accounts.Length; i++)
                {
                    if (_accounts[i].GetCurrentBalance() > richestBalanceAccount.GetCurrentBalance())
                    {
                        richestBalanceAccount = _accounts[i];
                    }
                }
            }
            catch (NullReferenceException)
            {
                return Messages.InvalidMessage;
            }
            catch (IndexOutOfRangeException)
            {
                return Messages.InvalidMessage;
            }

            return _accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(_accounts)
              ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.AreTheRichestPeople}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}."
              : $"{richestBalanceAccount.GetName()} {Messages.IsTheRichestPerson}. {StringOps.FormatCurrency(richestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }

        /// <summary>
        /// Return name and current money of the most poor person.
        /// </summary>
        public string FindMostPoorPerson()
        {
            Account poorestBalanceAccount;
            try
            {
                poorestBalanceAccount = _accounts[0];
                for (int i = 1; i < _accounts.Length; i++)
                {
                    if (_accounts[i].GetCurrentBalance() < poorestBalanceAccount.GetCurrentBalance())
                    {
                        poorestBalanceAccount = _accounts[i];
                    }
                }
            }
            catch (NullReferenceException)
            {
                return Messages.InvalidMessage;
            }
            catch (IndexOutOfRangeException)
            {
                return Messages.InvalidMessage;
            }

            return _accounts.Length > _arrayBreak && AccountOps.AreBalancesEqual(_accounts)
                ? $"{StringOps.FormatAndCommas(_accounts)} {Messages.HaveTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}."
                : $"{poorestBalanceAccount.GetName()} {Messages.HasTheLeastMoney}. {StringOps.FormatCurrency(poorestBalanceAccount.GetCurrentBalance(), _currency)}.";
        }
    }
}