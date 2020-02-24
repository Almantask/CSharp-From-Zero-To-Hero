using System;

namespace BootCamp.Chapter
{
    public static class AccountOps
    {
        public static string GetNameForPerson(string[] personAndBalance)
        {
            if (Test.IsName(personAndBalance[0]))
            {
                return personAndBalance[0];
            }
            return Messages.InvalidMessage;
        }

        public static decimal[] GetBalanceForPerson(string[] personAndBalance)
        {
            var newArray = new decimal[personAndBalance.Length - 1];
            for (int i = 1; i < personAndBalance.Length; i++)
            {
                newArray[i - 1] = Conversion.ConvertToDecimal(personAndBalance[i]);
            }
            return newArray;
        }

        public static Account[] BuildAccountList(string[] peopleAndBalances)
        {
            Account[] accounts;
            try
            {
                accounts = new Account[peopleAndBalances.Length];
                for (int i = 0; i < accounts.Length; i++)
                {
                    accounts[i] = new Account(peopleAndBalances[i]);
                }
            }
            catch (NullReferenceException)
            {
                return default;
            }
            catch (IndexOutOfRangeException)
            {
                return default;
            }
            return accounts;
        }

        public static bool AreBalancesEqual(Account[] accounts)
        {
            Account firstAccount = accounts[0];
            for (int i = 1; i < accounts.Length; i++)
            {
                if (!ArrayOps.AreArraysEqual(accounts[i].GetBalance(), firstAccount.GetBalance()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}