using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver

            Console.WriteLine("The richest person ever was : ");
            var answer = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            Console.WriteLine(TextTable.Build(answer, 3));

            // - FindPersonWithBiggestLoss

            //Console.WriteLine("The person with the biggest loss was  : ");
            //answer = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            //Console.WriteLine(TextTable.Build(answer, 3));

            // - FindRichestPerson

            Console.WriteLine("The richest person at this moment is : ");
            answer = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            Console.WriteLine(TextTable.Build(answer, 3));

            // - FindMostPoorPerson

            Console.WriteLine("The poorest person at this moment is : ");
            answer = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
            Console.WriteLine(TextTable.Build(answer, 3));
        }
    }
}