namespace BootCamp.Chapter
{
    public static class AccountOps
    {
        public static Account[] BuildAccountList(string[] peopleAndBalances)
        {
            Account[] accounts = new Account[peopleAndBalances.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = new Account(peopleAndBalances[i]);
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