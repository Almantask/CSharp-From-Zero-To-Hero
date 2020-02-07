using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var maxBalanceSp = BalanceStats.HighestBalanceForSinglePerson(PeoplesBalances.Balances[2]);
            Console.WriteLine(maxBalanceSp);
            var totalBalanceSp = BalanceStats.TotalBalanceForSinglePerson(PeoplesBalances.Balances[2]);
            Console.WriteLine(totalBalanceSp);
        }
    }
}