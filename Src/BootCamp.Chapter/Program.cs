using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BalanceStats.FindRichestPerson(PeoplesBalances.Balances));
            Console.WriteLine(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances));

            //string testString = " 99.99";
            //float testInt = float.Parse(testString);
            //Console.WriteLine(testInt);

            //Array.ForEach(PeoplesBalances.Balances, Console.WriteLine);
            //BalanceStats.FindRichestPerson(PeoplesBalances.Balances);
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson

            //string[][] parsedBalances = BalanceStats.ArrayifyBalances(PeoplesBalances.Balances);
            //for (int i = 0; i < parsedBalances.Length; i++)
            //{
            //    Console.WriteLine($"{parsedBalances[i][0]} has a ballance of {parsedBalances[i][^1]}");
            //}

            //for (int i = 0; i < parsedBalances.Length; i++)
            //{
            //    for (int j = 0; j < parsedBalances[i].Length; j++)
            //    {
            //        Console.WriteLine("Toot Toot!!!");
            //        Console.WriteLine(parsedBalances[i][j]);
            //    }
            //}
        }
    }
}
