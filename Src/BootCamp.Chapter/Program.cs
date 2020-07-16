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
            System.Console.WriteLine("--------------------------");
            string table = TextTable.Build("Hello{Environment.NewLine}World!", 0);
            System.Console.WriteLine(table);
            System.Console.WriteLine("--------------------------");
            table = TextTable.Build("Hello{Environment.NewLine}World!", 1);
            System.Console.WriteLine(table);
            System.Console.WriteLine("--------------------------");
            table = TextTable.Build("Hello{Environment.NewLine}World!", 2);
            System.Console.WriteLine(table);
        }
    }
}
