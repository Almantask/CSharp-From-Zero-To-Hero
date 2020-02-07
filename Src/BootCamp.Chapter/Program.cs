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
            var personNameSb = BalanceStats.ReturnNameForSingleBalance(PeoplesBalances.Balances[1]);
            Console.WriteLine(personNameSb);
            var maxBalanceSp = BalanceStats.HighestBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(maxBalanceSp);
            var totalBalanceSp = BalanceStats.TotalBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(totalBalanceSp);
            var lastBalanceSp = BalanceStats.LastBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(lastBalanceSp);
            var lowestBalanceSp = BalanceStats.LowestBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(lowestBalanceSp);
        }
    }
}