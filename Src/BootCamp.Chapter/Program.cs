using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class Program
    {
        //Corrupted balance file from finance department store.
        private const string CorruptedBalanceFile = @"..\..\..\Input\Balances.corrupted";
        //Fixed balance file to help finance department store.
        private const string FixedBalanceFile = @"..\..\..\Input\Balances.fixed";
        //Dollar sign.
        private const char DollarSign = '€';

        static void Main(string[] args)
        {
            var corruptedBalanceLines = File.ReadAllLines(CorruptedBalanceFile);
            var fixedBalanceLines = new string[corruptedBalanceLines.Length];

            FixCorruptedBalanceFile(corruptedBalanceLines, fixedBalanceLines);
            DisplayStasticalData(CreateBalanceLinesForTextTable(fixedBalanceLines));
        }

        private static string[] CreateBalanceLinesForTextTable(string[] fixedBalanceLines)
        {
            var balanceLinesForTextTable = new string[fixedBalanceLines.Length];
            var balanceSeperator = "," + DollarSign + " ";

            for (int i = 0; i < fixedBalanceLines.Length; i++)
            {
                var balances = fixedBalanceLines[i].Split(balanceSeperator);
                var balanceLine = new StringBuilder(balances[0]);

                for (int j = 1; j < balances.Length; j++)
                {
                    balanceLine.Append(", ");
                    balanceLine.Append(balances[j].Replace(",", "."));
                }

                balanceLinesForTextTable[i] = balanceLine.ToString();
            }

            return balanceLinesForTextTable;
        }

        private static void FixCorruptedBalanceFile(string[] corruptedBalanceLines, string[] fixedBalanceLines)
        {
            for (var i = 0; i < corruptedBalanceLines.Length; i++)
            {
                fixedBalanceLines[i] = corruptedBalanceLines[i].Replace("_", "");
            }

            File.WriteAllLines(FixedBalanceFile, fixedBalanceLines);
        }

        private static void DisplayStasticalData(string[] peopleBalances)
        {
            // Using FindHighestBalanceEver, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(peopleBalances), 3));

            // Using FindPersonWithBiggestLoss, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(peopleBalances), 3));

            // Using FindRichestPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(peopleBalances), 3));

            // Using FindMostPoorPerson, print the statistical output using Text Table with padding 3.
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(peopleBalances), 3));
        }
    }

}
