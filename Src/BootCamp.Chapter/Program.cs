using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var balances = new BalanceDatabase();
            balances.AddNewPerson("Tom", new List<decimal>() { (decimal)15.5, (decimal)200, (decimal)500, (decimal)600, (decimal)200, (decimal)500, (decimal)1000 });
            balances.AddNewPerson("Katherine", new List<decimal>() { (decimal)85, (decimal)0, (decimal)-500, (decimal)0, (decimal)500, (decimal)10000, (decimal)1500.99 });
            balances.AddNewPerson("Joseph", new List<decimal>() { (decimal)85, (decimal)0, (decimal)-500, (decimal)0, (decimal)500, (decimal)10000, (decimal)1500.99 });
            balances.AddNewPerson("Bill", new List<decimal>() { (decimal)99999, (decimal)99970, (decimal)99900 });
            balances.AddNewPerson("Mat", new List<decimal>() { (decimal)99999, (decimal)99970, (decimal)99900 });
            balances.AddNewPerson("Catie", new List<decimal>() { (decimal)0, (decimal)500, (decimal)990, (decimal)1300 });

            var hue = balances.GetMaxLoss();
            var hue2 = balances.GetMaxBalance();
            var hue3 = balances.GetRichestPerson();
            var hue4 = balances.GetMostPoorPerson();

            //var test = new List<decimal>() {(decimal) 0, (decimal) 500, (decimal) 990, (decimal) 1300};

            //var ha = string.Join(", ", test);

            //var people = new string[] {
            //    "Tom, 15.5, 200, 500, 600, 200, 500, 1000",
            //    "Katherine, 85, 0, -500, 0, 500, 10000, 1500.99",
            //    "Bill, 99999, , 99970, 99900",
            //    "Catie, 0, 500, 990, 1300"
            //};


            //var balances2 = BalanceStats.CreateBalanceDatabase(people);


            //var test2 = new string[] {"Tom, 1"};

            //var hueM = Checks.FindPersonWithBiggestLoss(test2);

            Console.WriteLine("Hue");
        }
    }
}
