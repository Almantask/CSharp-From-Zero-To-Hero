using System;
using System.IO;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // part1
            RepairCorruptedFile();

            // part2

            FindStaticalData();
        }

        private static void FindStaticalData()
        {
            string[] contents = File.ReadAllLines(@"Input\Balances.clean");

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

        private static void RepairCorruptedFile()
        {
            var contents = File.ReadAllLines(@"Input\Balances.corrupted");
            for (int i = 0; i < contents.Length; i++)
            {
                var repairedText = contents[i].Replace("_", "");
                repairedText += Environment.NewLine;
                if (i == 0)
                {
                    File.WriteAllText(@"Input\Balances.clean", repairedText);
                }
                else
                {
                    File.AppendAllText(@"Input\Balances.clean", repairedText);
                }
            }

           
        }
    }
}