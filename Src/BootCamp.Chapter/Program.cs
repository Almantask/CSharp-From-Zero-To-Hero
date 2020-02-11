using System.Text;
using static BootCamp.Chapter.TextTable;
using static System.Console;

namespace BootCamp.Chapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
            // set currency symbol and position for BlanceStats.FormatCurrency method
            BalanceStats.DefaultCurrencySymbol = "€";
            BalanceStats.DefaultCurrencySymbolPosition = 1;

            const int padding = 3;
            OutputEncoding = Encoding.UTF8;

            // runs statistics methods on Ballances.corrupted

            var repairedPeopeAndBalances = FilesUtility.MakeBalancesParsable();

            WriteLine(Build(BalanceStats.FindHighestBalanceEver(repairedPeopeAndBalances), padding));

            WriteLine(Build(BalanceStats.FindMostPoorPerson(repairedPeopeAndBalances), padding));

            WriteLine(Build(BalanceStats.FindPersonWithBiggestLoss(repairedPeopeAndBalances), padding));

            WriteLine(Build(BalanceStats.FindRichestPerson(repairedPeopeAndBalances), padding));

            // Creates Balances.repaired
            FilesUtility.RepairPeopleAndBalances(FilesUtility.CoruptedFile, FilesUtility.RepairedFile);
        }
    }
}