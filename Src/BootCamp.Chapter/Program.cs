namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            //BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            //BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            //BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
        }
    }
}
