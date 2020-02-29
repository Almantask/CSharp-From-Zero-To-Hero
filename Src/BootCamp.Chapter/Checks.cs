namespace BootCamp.Chapter
{
    // This class is used to have a freedom of design, but with tests applied.
    public static class Checks
    {
        public static string FindMostPoorPerson(string[] peopleAndBalances)
        {
            Account[] accounts = AccountOps.BuildAccountList(peopleAndBalances);
            BalanceStats balanceStats = new BalanceStats(accounts);

            return balanceStats.FindMostPoorPerson();
        }

        public static string FindRichestPerson(string[] peopleAndBalances)
        {
            Account[] accounts = AccountOps.BuildAccountList(peopleAndBalances);
            BalanceStats balanceStats = new BalanceStats(accounts);

            return balanceStats.FindRichestPerson();
        }

        public static string FindPersonWithBiggestLoss(string[] peopleAndBalances)
        {
            Account[] accounts = AccountOps.BuildAccountList(peopleAndBalances);
            BalanceStats balanceStats = new BalanceStats(accounts);

            return balanceStats.FindPersonWithBiggestLoss();
        }

        public static string FindHighestBalanceEver(string[] peopleAndBalances)
        {
            Account[] accounts = AccountOps.BuildAccountList(peopleAndBalances);
            BalanceStats balanceStats = new BalanceStats(accounts);

            return balanceStats.FindHighestBalanceEver();
        }

        public static string Build(string message, in int padding)
        {
            TextTable textTable = new TextTable(message, padding);

            return textTable.Build();
        }

        public static void Clean(string file, string outputFile)
        {
            FileCleaner fileCleaner = new FileCleaner(file, outputFile);
            fileCleaner.Clean();
        }
    }
}