using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"Input\Balances.corrupted";

            var fileWithBalances = new FileWithBalances(filePath);

            var peopleAndBalances = new PeopleAndBalances(fileWithBalances.GetContent());

            string highestEver = peopleAndBalances.FindHighestBalanceEver();
            System.Console.WriteLine(highestEver);

            string biggestLoss = peopleAndBalances.FindPersonWithBiggestLoss();
            System.Console.WriteLine(biggestLoss);

            string richest = peopleAndBalances.FindRichestPerson();
            System.Console.WriteLine(richest);

            string poorest = peopleAndBalances.FindPoorestPerson();
            System.Console.WriteLine(poorest);
        }
    }
}
