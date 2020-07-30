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
        const string cleanedFile = @"Input\Balances.clean";

        static void Main(string[] args)
        {
            var insideFile = File.ReadAllText(cleanedFile);
            var peopleAndBalances = insideFile.Split(Environment.NewLine);


            Console.WriteLine(Checks.Build(Checks.FindHighestBalanceEver(peopleAndBalances), 3));
            Console.WriteLine(Checks.Build(Checks.FindMostPoorPerson(peopleAndBalances), 3));
            Console.WriteLine(Checks.Build(Checks.FindPersonWithBiggestLoss(peopleAndBalances), 3));
            Console.WriteLine(Checks.Build(Checks.FindRichestPerson(peopleAndBalances), 3));
        }
    }
}
