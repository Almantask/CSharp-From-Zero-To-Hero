using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {   
            //part 1
            FileCleaner.Clean(@"Input\Balances.corrupted", @"Input\Balances.clean");

            Part2();
        }

        static void Part2()
        {
            var fileContent = File.ReadAllText(@"Input\Balances.clean");
            var peopleAndBalances = fileContent.Split(Environment.NewLine);

            //    BalanceStats.ConvertToBalanceArray(peopleAndBalances[0]);
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(peopleAndBalances));
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(peopleAndBalances));
            Console.WriteLine(BalanceStats.FindRichestPerson(peopleAndBalances));
            Console.WriteLine(BalanceStats.FindMostPoorPerson(peopleAndBalances));
        }
    }
}
