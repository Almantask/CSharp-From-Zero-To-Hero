using System;
using System.Diagnostics;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
		const int PADDING = 3;
        static void Main(string[] args)
        {
			// Print each of the statistical output using Text Table with padding 3:
			// - FindHighestBalanceEver
			Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), PADDING));
			// - FindPersonWithBiggestLoss
			Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), PADDING));
			// - FindRichestPerson
			Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), PADDING));
			// - FindMostPoorPerson
			Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), PADDING));

			Console.ReadLine();
		}
    }
}
