using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            const int padding = 3;

            var highestBalanceEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), padding);
            Console.WriteLine(highestBalanceEver);

            var personWithBiggestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), padding);
            Console.WriteLine(personWithBiggestLoss);

            var richestperson = TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), padding);
            Console.WriteLine(richestperson);

            var poorestPerson = TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), padding);
            Console.WriteLine(poorestPerson);
        }
    }
}