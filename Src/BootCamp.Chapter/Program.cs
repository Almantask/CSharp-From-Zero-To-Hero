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
            var peopleBalances = PeoplesBalances.Balances;
            string highestEver = BalanceStats.FindHighestBalanceEver(peopleBalances);
            System.Console.WriteLine(highestEver);
            string biggestLoss = BalanceStats.FindPersonWithBiggestLoss(peopleBalances);
            System.Console.WriteLine(biggestLoss);
            string richest = BalanceStats.FindRichestPerson(peopleBalances);
            System.Console.WriteLine(richest);
            string poorest = BalanceStats.FindMostPoorPerson(peopleBalances);
            System.Console.WriteLine(poorest);

        }
    }
}
