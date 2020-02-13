using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TextTable.Build("Hello", 0);
            TextTable.Build1($"Hello{Environment.NewLine}World!", 0);
            TextTable.Build2("Hello", 1);

            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
        }
    }
}
