using System;

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
            //string highestBalance = BalanceStats.FindHighestBalanceEver(Person3Same);
            //System.Console.WriteLine(highestBalance);

            //TextTable.Build($"Hello{Environment.NewLine}World!", 1);
           
            string s = TextTable.Build($"Hello{Environment.NewLine}World!", 1);
            string s1 = TextTable.Build($"Hello", 1);
            System.Console.Write(s1.Length);



            //string biggestLoss = BalanceStats.FindPersonWithBiggestLoss(Person3Balance3);
            ////TextTable.Build(biggestLoss, 3);
            //System.Console.WriteLine(biggestLoss);

            //string richestPerson = BalanceStats.FindRichestPerson(Person1Balance2);
            ////TextTable.Build(richestPerson, 3);
            //System.Console.WriteLine(richestPerson);

            //string mostPoorPerson = BalanceStats.FindMostPoorPerson(Person3Same);
            ////TextTable.Build(mostPoorPerson, 3);
            //System.Console.WriteLine(mostPoorPerson);

        }
        public static string[] Person1Balance2 => new[] { "Tom, 1, 0" };
        public static string[] Person3Same => new[] { "Tom, 1", "Gillie, 1", "Agnes, 1" };
        public static string[] Person3Balance3 => new[] { "Tom, 1, 3, -1", "Gillie, 2, 3, 1", "Thor, 1000, 1001, 1002" };
    }
}
