using System;
namespace BootCamp.Chapter
{
    class Program
    {

        private static int padding = 3;
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            Console.WriteLine(
                TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), padding)
                );
            Console.WriteLine(
                TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), padding)
                );
            Console.WriteLine(
                TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), padding)
                );
            Console.WriteLine(
                TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), padding)
                );
        }
    }
}
