using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Using FindHighestBalanceEver, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), 3));

            // Using FindPersonWithBiggestLoss, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), 3));

            // Using FindRichestPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), 3));

            // Using FindMostPoorPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), 3));
        }
    }
}
