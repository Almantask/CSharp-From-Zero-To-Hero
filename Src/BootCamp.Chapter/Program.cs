using System;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string FixedFilePath = @"..\..\..\Input\Balances.fixed";
        private const int padding = 3;

        static void Main(string[] args)
        {
            var fixedLines = FileUtilities.MakeContentParsable(FixedFilePath, "£"); // We make content parsable so it can be printed to the console
            Console.WriteLine(TextTable.Build(BalanceStats.FindHighestBalanceEver(fixedLines), padding));
            Console.WriteLine(TextTable.Build(BalanceStats.FindMostPoorPerson(fixedLines), padding));
            Console.WriteLine(TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(fixedLines), padding));
            Console.WriteLine(TextTable.Build(BalanceStats.FindRichestPerson(fixedLines), padding));
        }
    }
}
