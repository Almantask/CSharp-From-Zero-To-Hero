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

            string highestEver = TextTable.Build(BalanceStats.FindHighestBalanceEver(peopleBalances), 3);
            System.Console.WriteLine(highestEver);

            string biggestLoss = TextTable.Build(BalanceStats.FindPersonWithBiggestLoss(peopleBalances), 3);
            System.Console.WriteLine(biggestLoss);

            string richest = TextTable.Build(BalanceStats.FindRichestPerson(peopleBalances), 3);
            System.Console.WriteLine(richest);

            string poorest = TextTable.Build(BalanceStats.FindMostPoorPerson(peopleBalances), 3);
            System.Console.WriteLine(poorest);
        }
    }
}
