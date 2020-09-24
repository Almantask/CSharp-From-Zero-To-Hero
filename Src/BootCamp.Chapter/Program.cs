namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            // - FindPersonWithBiggestLoss
            BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            // - FindRichestPerson
            BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            // - FindMostPoorPerson
            BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
        }
    }
}
