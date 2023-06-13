using System;
using System.Diagnostics;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
			string message = "test\ntest2";
			Console.WriteLine(TextTable.Build(message, 0));
			Console.WriteLine(TextTable.Build(message, 1));
			Console.WriteLine(TextTable.Build(message, 2));

			// Print each of the statistical output using Text Table with padding 3:
			// - FindHighestBalanceEver
			// - FindPersonWithBiggestLoss
			// - FindRichestPerson
			// - FindMostPoorPerson

			Console.ReadLine();
		}
    }
}
