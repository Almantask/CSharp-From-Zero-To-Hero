using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"Input\Balances.corrupted";

            var fileWithBalances = new FileWithBalances(filePath);
            System.Console.WriteLine(fileWithBalances.GetContent());

            //var peopleBalances = new StringBuilder();
            //peopleBalances.Append(File.ReadAllText(cleanFile));


            //string highestEver = BalanceStats.FindHighestBalanceEver(cleanFile);
            //System.Console.WriteLine(highestEver);

            //string biggestLoss = BalanceStats.FindPersonWithBiggestLoss(cleanFile);
            //System.Console.WriteLine(biggestLoss);

            //string richest = BalanceStats.FindRichestPerson(cleanFile);
            //System.Console.WriteLine(richest);

            //string poorest = BalanceStats.FindMostPoorPerson(cleanFile);
            //System.Console.WriteLine(poorest);
        }
    }
}
