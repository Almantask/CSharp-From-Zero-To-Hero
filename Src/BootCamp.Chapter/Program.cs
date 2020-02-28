using System;
using System.Text;

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

            Console.WriteLine(TextTable.Build($"Hello{Environment.NewLine}World!{Environment.NewLine}Very Long Line!!!", 6));

        }
    }
}
