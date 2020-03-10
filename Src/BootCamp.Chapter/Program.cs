using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(BalanceStats.FindRichestPerson(PeoplesBalances.Balances));
            //Console.WriteLine(BalanceStats.FindMostPoorPerson(PeoplesBalances.Balances));

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
            string[] stringArr = new string[] { "Tom, 15.5, 200, 500, 600, 200, 500, 1000", 
                "Katherine, 85, 0, -500, 0, 500, 10000, 1500.99", 
                "Test, 85, 0, -500, 0, 500, 10000, 1500.99",
                "Test2, 85, 0, -500, a, 500, 10000, 1500.99",
                "Catie, 0, 500, 990, 1300" };
            //float[] floatArr = new float[] { 85, 0, -500, 0, 500, 10000, 1500.99f };
            //Console.WriteLine(BalanceStats.HighestBalance(BalanceStats.StringArrToFloatArr(stringArr[1..])));

            //float[] floatArr2 = BalanceStats.StringArrToFloatArr(stringArr[1..]);
            //Array.ForEach(floatArr2, Console.WriteLine);

            //Console.WriteLine(BalanceStats.FindHighestBalanceEver(PeoplesBalances.Balances));
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(stringArr));
            //string newString = "Bill, Tedd, Frank, ";
            //Console.WriteLine(BalanceStats.FormatBalanceNames(newString));
        }
    }
}
