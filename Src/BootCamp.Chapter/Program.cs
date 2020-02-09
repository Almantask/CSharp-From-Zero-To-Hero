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
            var contents = File.ReadAllLines(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input/Balances.corrupted");
            for (int i = 0; i < contents.Length; i++)
            {
                var repairedText = contents[i].ToString().Replace("_", "");
                repairedText += Environment.NewLine;
                if (i == 0)
                {
                    File.WriteAllText(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances2.txt", repairedText);
                }
                else
                {
                    File.AppendAllText(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances2.txt", repairedText);
                }
                
            }
            

            // part2

            contents = File.ReadAllLines(@"C:\Users\roelof\source\repos\RoelofWobben\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input/Balances.txt");

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



/* 

Mirabelle Quinnell,€ 73,44,€ 220,32,€ -36,72,€ 293,76,€ -76,50,€ -284,58
Mirabelle Quinnell,€ 99,66,€ -81,54,€ 223,48,€ -108,72,€ -72,48,€ -87,58,

 
*/
