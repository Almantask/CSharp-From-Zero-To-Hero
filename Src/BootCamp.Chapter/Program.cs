using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var contents = FileCleaner.Clean(@"Input\Balances.corrupted", @"Input\Balances.clean");
            

        }

       


        private static void FindStaticalData()
        {
            //string[] contents = File.ReadAllLines(@"Input\Balances.clean");

            //// Print each of the statistical output using Text Table with padding 3:

            //// - FindHighestBalanceEver

            //Console.WriteLine("The richest person ever was : ");
            //var answer = BalanceStats.FindHighestBalanceEver(contents);
            //Console.WriteLine(TextTable.Build(answer, 3));

            //// - FindPersonWithBiggestLoss

            //Console.WriteLine("The person with the biggest loss was  : ");
            //answer = BalanceStats.FindPersonWithBiggestLoss(contents);
            //Console.WriteLine(TextTable.Build(answer, 3));

            //// - FindRichestPerson

            //Console.WriteLine("The richest person at this moment is : ");
            //answer = BalanceStats.FindRichestPerson(contents);
            //Console.WriteLine(TextTable.Build(answer, 3));

            //// - FindMostPoorPerson

            //Console.WriteLine("The poorest person at this moment is : ");
            //answer = BalanceStats.FindMostPoorPerson(contents);
            //Console.WriteLine(TextTable.Build(answer, 3));

        }


    }
}