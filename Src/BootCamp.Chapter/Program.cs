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

            var highestBalanceEver = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            var personWithBiggestLoss = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            var richestPerson = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            var mostPoorPerson = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);

            Console.WriteLine(TextTable.Build(highestBalanceEver, 3));
            Console.WriteLine(TextTable.Build(personWithBiggestLoss, 3));
            Console.WriteLine(TextTable.Build(richestPerson, 3));
            Console.WriteLine(TextTable.Build(mostPoorPerson, 3));
        }
    }
}
