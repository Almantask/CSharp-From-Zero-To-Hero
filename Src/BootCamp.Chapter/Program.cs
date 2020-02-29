using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stats = new string[4];
            stats[0] = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            stats[1] = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            stats[2] = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            stats[3] = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);

            const int padding = 3;
            foreach (string result in stats)
            {
                Console.WriteLine(TextTable.Build(result, padding));
            }
        }
    }
}
