using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);

            BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);

            BalanceStats.FindRichestPerson(PeoplesBalances.Balances);

            BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
        }
    }
}
