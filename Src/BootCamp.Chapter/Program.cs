using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stats = new string[4];
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            stats[0] = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            // - FindPersonWithBiggestLoss
            stats[1] = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            // - FindRichestPerson
            stats[2] = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            // - FindMostPoorPerson
            stats[3] = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);

            int padding = 3;
            foreach (string result in stats)
            {
                Console.WriteLine(TextTable.Build(result, padding));
            }
        }
    }
}
