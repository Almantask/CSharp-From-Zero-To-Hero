using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances),3));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), 3));
            // - FindRichestPerson
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), 3));
            // - FindMostPoorPerson
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), 3));
        }
    }
}
