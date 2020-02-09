using System;
using System.IO;

namespace BootCamp.Chapter
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            //const int padding = 3;

            //var highestBalanceEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances), padding);
            //Console.WriteLine(highestBalanceEver);

            //var personWithBiggestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances), padding);
            //Console.WriteLine(personWithBiggestLoss);

            //var richestperson = TextTable.Build(BalanceStats.FindRichestPerson(PeoplesBalances.Balances), padding);
            //Console.WriteLine(richestperson);

            //var poorestPerson = TextTable.Build(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances), padding);
            //Console.WriteLine(poorestPerson);

            PrintFileToConsole();
        }

        private static void PrintFileToConsole()
        {
            const string fileLocation = @"\Input\Balances.corrupted";
            string rootPath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            string filePath = rootPath + fileLocation;

            Console.WriteLine(filePath);

            using (StreamReader reader = new StreamReader(filePath))
            {
                var contents = reader.ReadToEnd();
                var poorestPerson = TextTable.Build(BalanceStats.FindMostPoorPerson(new string[] { contents }), 3);
                var richestPerson = TextTable.Build(BalanceStats.FindRichestPerson(new string[] { contents }), 3);
                var persontWithBigestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(new string[] { contents }), 3);
                var highestBalanceEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(new string[] { contents }), 3);
                Console.WriteLine(poorestPerson);
                Console.WriteLine(richestPerson);
                Console.WriteLine(persontWithBigestLoss);
                Console.WriteLine(highestBalanceEver);
            }
        }
    }
}