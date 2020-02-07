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
            var names = new[] { "Mihail", "Goku" };
            var arrayElements = new decimal[] { 1, 1, 2 };
            Console.WriteLine(BalanceStats.ArrayElementsAreEqual(arrayElements));
            var personNameSb = BalanceStats.ReturnNameForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(personNameSb);
            var maxBalanceSp = BalanceStats.HighestBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(maxBalanceSp);
            var totalBalanceSp = BalanceStats.TotalBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(totalBalanceSp);
            //var lastBalanceSp = BalanceStats.LastBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            //Console.WriteLine(lastBalanceSp);
            var lowestBalanceSp = BalanceStats.LowestBalanceForSinglePerson(PeoplesBalances.Balances[1]);
            Console.WriteLine(lowestBalanceSp);
            var formatedText = BalanceStats.FormatStringAndCommas(names);
            Console.WriteLine(formatedText);

            Console.WriteLine();
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances));

            Console.WriteLine();
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances));

            Console.WriteLine();
            Console.WriteLine(BalanceStats.CalculateLossForSinglePerson(PeoplesBalances.Balances[1]).ToString(BalanceStats.numberFormatInfo));
        }
    }
}