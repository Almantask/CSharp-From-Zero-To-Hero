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
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            ///<summary>
            /// Fix the file, by removing _
            ///</summary>
            FileCleaner.Clean(@"C:\Users\piotr\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted", @"C:\Users\piotr\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.clean");
            
            ///<summary>
            /// Parse line by line to string array 
            /// </summary>
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\piotr\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.clean");

            ///<summary>
            /// Remove currency
            /// </summary>
            for (int i=0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace("£","");
            }

            var tableOfBalances = lines;

            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(tableOfBalances));
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(tableOfBalances));
            Console.WriteLine(BalanceStats.FindRichestPerson(tableOfBalances));
            Console.WriteLine(BalanceStats.FindMostPoorPerson(tableOfBalances));

            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(tableOfBalances), 3));
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(tableOfBalances), 3));


            Console.ReadKey();
        }
    }
}
