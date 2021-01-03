namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:

            // - FindHighestBalanceEver
            var highestBalanceEver = BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances);
            System.Console.WriteLine(TextTable.Build(highestBalanceEver, 3));

            // - FindPersonWithBiggestLoss
            var personWithBiggestLoss = BalanceStats.FindPersonWithBiggestLoss(PeoplesBalances.Balances);
            System.Console.WriteLine(TextTable.Build(personWithBiggestLoss, 3));

            // - FindRichestPerson
            var richestPerson = BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            System.Console.WriteLine(TextTable.Build(richestPerson, 3));

            // - FindMostPoorPerson
            var mostPoorPerson = BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances);
            System.Console.WriteLine(TextTable.Build(mostPoorPerson, 3));
        }
    }
}
