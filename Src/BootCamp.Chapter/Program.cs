using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleBalances = PeoplesBalances.Balances;

            string highestEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(peopleBalances), 3);
            System.Console.WriteLine(highestEver);

            string biggestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(peopleBalances), 3);
            System.Console.WriteLine(biggestLoss);

            string richest = TextTable.Build(BalanceStats.FindRichestPerson(peopleBalances), 3);
            System.Console.WriteLine(richest);

            string poorest = TextTable.Build(BalanceStats.FindMostPoorPerson(peopleBalances), 3);
            System.Console.WriteLine(poorest);
        }
    }
}
