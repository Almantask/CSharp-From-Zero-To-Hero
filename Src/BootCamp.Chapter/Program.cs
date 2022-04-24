namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
            System.Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), 3));
            System.Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), 3));
            System.Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), 3));
            System.Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), 3));
        }
    }
}
