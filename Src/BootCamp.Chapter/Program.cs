using System;

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

            var result = TextTable.Build($"How{Environment.NewLine}About{Environment.NewLine}This?{Environment.NewLine}", 5);
            Console.WriteLine(result);
        }
    }
}
