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

            BalanceStats.FindPersonWithBiggestLoss(new[] { "Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002" });
        }
    }
}
