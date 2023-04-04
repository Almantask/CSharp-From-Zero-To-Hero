using System;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {


        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            string corrupted = @"C:\Users\Pedro Win\Documents\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.corrupted";
            string cleaned = @"C:\Users\Pedro Win\Documents\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Balances.cleaned";
            FileCleaner.Clean(corrupted, cleaned);
            var lines = File.ReadAllText(cleaned).Split("\r\n");

            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            Console.WriteLine(TextTable.Build(Checks.FindHighestBalanceEver(lines), 3));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(TextTable.Build(Checks.FindPersonWithBiggestLoss(lines), 3));
            // - FindRichestPerson
            Console.WriteLine(TextTable.Build(Checks.FindRichestPerson(lines), 3));
            // - FindMostPoorPerson
            Console.WriteLine(TextTable.Build(Checks.FindMostPoorPerson(lines), 3));
        }
    }
}
