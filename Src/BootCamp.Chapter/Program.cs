using System;
using System.Text;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //TextTable.Build($"Hello{Environment.NewLine}World!", 2);
            BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            // BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
        }
    }
}
