using System;

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
            TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), 3);
            TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), 3);
            TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), 3);
            TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), 3);

        }
    }
}
