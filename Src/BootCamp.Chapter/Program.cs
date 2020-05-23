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
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), 3));
            BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            BalanceStats.FindRichestPerson(PeoplesBalances.Balances);

        }
    }
}
