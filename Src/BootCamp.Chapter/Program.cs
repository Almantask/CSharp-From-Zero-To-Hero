using System;
using System.IO;
using System.Text;
using static BootCamp.Chapter.TextTable;
using static BootCamp.Chapter.BalanceStats;
using static BootCamp.Chapter.FilesUtility;
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
            const int padding = 3;
            OutputEncoding = Encoding.UTF8;

            var repairedPeopeAndBalances = MakeBalancesParsable();

            WriteLine(Build(FindHighestBalanceEver(repairedPeopeAndBalances), padding));

            WriteLine(Build(FindMostPoorPerson(repairedPeopeAndBalances), padding));

            WriteLine(Build(FindPersonWithBiggestLoss(repairedPeopeAndBalances), padding));

            WriteLine(Build(FindRichestPerson(repairedPeopeAndBalances), padding));

            RepairPeopleAndBalances(coruptedFile, repairedFile);
        }
    }
}