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
        static void Main(string[] args)
        {
            // part1 
            var contents = File.ReadAllLines(@"Input\Balances.corrupted");
            for (int i = 0; i < contents.Length; i++)
            {
                var repairedText = contents[i].Replace("_", "");
                repairedText += Environment.NewLine;
                if (i == 0)
                {
                    File.WriteAllText(@"Input\Balances.txt", repairedText);
                }
                else
                {
                    File.AppendAllText(@"Input\Balances.txt", repairedText);
                }
                
            }
            

            // part2

            contents = File.ReadAllLines(@"Input\Balances.txt");

            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver

            Console.WriteLine("The richest person ever was : ");
            var answer = BalanceStats.FindHighestBalanceEver(contents);
            Console.WriteLine(TextTable.Build(answer, 3));

            // - FindPersonWithBiggestLoss

            Console.WriteLine("The person with the biggest loss was  : ");
            answer = BalanceStats.FindPersonWithBiggestLoss(contents);
            Console.WriteLine(TextTable.Build(answer, 3));

            // - FindRichestPerson

            Console.WriteLine("The richest person at this moment is : ");
            answer = BalanceStats.FindRichestPerson(contents);
            Console.WriteLine(TextTable.Build(answer, 3));

            // - FindMostPoorPerson

            Console.WriteLine("The poorest person at this moment is : ");
            answer = BalanceStats.FindMostPoorPerson(contents);
            Console.WriteLine(TextTable.Build(answer, 3));


        }
    }
}




