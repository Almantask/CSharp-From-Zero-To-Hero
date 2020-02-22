namespace BootCamp.Chapter
{
    public static class AccountOps
    {
        public static string GetNameForPerson(string personAndBalance)
        {
            var balanceList = personAndBalance.Split(',');

            if (Test.IsStringValid(balanceList[0]))
            {
                return balanceList[0];
            }

            return StringOps.InvalidMessage;
        }

        public static decimal[] GetBalanceForPerson(string personAndBalance)
        {
            if (!Test.IsStringValid(personAndBalance))
            {
                return default;
            }

            var array = personAndBalance.Split(',');
            var newArray = new decimal[array.Length - 1];

            for (int i = 1; i < array.Length; i++)
            {
                newArray[i - 1] = Test.ConvertToDecimal(array[i]);
            }

            return newArray;
        }

        public static Account[] BuildAccountList(string[] peopleAndBalances)
        {
            Account[] accounts = new Account[peopleAndBalances.Length];
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = new Account(peopleAndBalances[i]);
            }

            return accounts;
        }

        public static bool AreAccountsBallancesEqual(Account[] accounts)
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