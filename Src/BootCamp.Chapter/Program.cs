using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances));
            // - FindRichestPerson
            Console.WriteLine(BalanceStats.FindRichestPerson(PeoplesBalances.Balances)); 
            // - FindMostPoorPerson
            Console.WriteLine(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances));
            Console.WriteLine(TextTable.Build("Hello", 0));
            Console.WriteLine(TextTable.Build($"Hello{Environment.NewLine}World!", 0));
            Console.WriteLine(TextTable.Build("Hello", 4));
        }
    }
}
