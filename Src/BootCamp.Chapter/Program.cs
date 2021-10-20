using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

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


            var tableOfBalances = PeoplesBalances.Balances;
           
            Console.WriteLine( BalanceStats.FindHighestBalanceEver(tableOfBalances));

            BalanceStats.FindRichestPerson(tableOfBalances);

            BalanceStats.FindMostPoorPerson(tableOfBalances);


            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(tableOfBalances), 3));
            //CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(tableOfBalances), 3));


            Console.ReadKey();
        }
    }
}
