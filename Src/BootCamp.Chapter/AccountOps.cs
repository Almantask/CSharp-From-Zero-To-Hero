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
            decimal[] newArray = new decimal[personAndBalance.Length - 1];
            for (int i = 1; i < personAndBalance.Length; i++)
            {
                newArray[i - 1] = Conversion.ToDecimal(personAndBalance[i]);
            }
            return newArray;
        }

        public static Account[] BuildAccountList(string[] peopleAndBalances)
        {
            if (peopleAndBalances is null || peopleAndBalances.Length == 0)
            {
                return default;
            }
            Account[] accounts = new Account[peopleAndBalances.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                string[] accountArray = ArrayOps.CreateAccount(peopleAndBalances[i]);
                accounts[i] = new Account(GetNameForPerson(accountArray), GetBalanceForPerson(accountArray));
            }

            return accounts;
        }

        public static bool CheckBalancesEquality(Account[] accounts)
        {
            Account firstAccount = accounts[0];
            for (int i = 1; i < accounts.Length; i++)
            {
                if (!ArrayOps.CheckEquality(accounts[i].GetBalance(), firstAccount.GetBalance()))
                {
                    return false;
                }
            }
            return true;
        }
    }
}