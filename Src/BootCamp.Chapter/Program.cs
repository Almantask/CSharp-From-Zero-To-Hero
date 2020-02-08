using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
            //"Tom, 15.5, 200, 500, 600, 200, 500, 1000",
            //"Katherine, 85, 0, -500, 0, 500, 10000, 1500.99",
            //"Bill, 99999, , 99970, 99900",
            //"Catie, 0, 500, 990, 1300"

        static void Main(string[] args)
        {
            System.Console.WriteLine();
            var people = PeoplesBalances.Balances;

            var personAndBalance = "Tom, 1,3, -1"; //-400 
            var personAndBalance2 = "Katherine, 85, 0, -500, 0, 500, 10000, 1500.99"; // -8499.01
            var personAndBalance3 = "Bill, 99999, 10 , 99970, 99900"; // -99989
            var personAndBalance4 = "Catie, 0, 500, 990, 1300"; // 0

            string[] foo = { "Tom, 1", "Gillie, 1", "Agnes, 1" };

            string[] foo1 = { "Tom, 1, 0" };
            string[] foo2 = { "Tom, 1", "Tom, 1" };
            string two = "2";
            string four = "4";

            int du = -2000;
            var bar = $"{du:C0}";

          //  var formated = (foo2.Length > 1) ? "are" : "is";

          //  Console.WriteLine(formated);

           

          //  Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(people));

            //var foobar = bar.NumberNegativePattern;
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

           // Console.WriteLine(BalanceStats.IsValidForCheck(people));

          //  var personAndBalanceArray = ConvertToArray(personAndBalance);

            //  Console.WriteLine(BalanceStats.FindHighestBalanceEver(people));

       //     Console.WriteLine(Barara(personAndBalance));

            //  System.Console.WriteLine(foo);



            //  System.Console.WriteLine(two.CompareTo(four));

            // ¤2.00000
            //  System.Console.WriteLine($"{du:C5}");

            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
        }

       

    }
}
