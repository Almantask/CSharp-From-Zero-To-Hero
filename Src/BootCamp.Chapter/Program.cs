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
            string dirtyFile = @"C:\Users\AK055494\OneDrive - Cerner Corporation\Avinash K\Repos\CSharp\CSharp_Repo\Src\BootCamp.Chapter\Input1\Balances.corrupted";
            string CleanFile = @"C:\Users\AK055494\OneDrive - Cerner Corporation\Avinash K\Repos\CSharp\CSharp_Repo\Src\BootCamp.Chapter\Input1\Balances.clean";
            FileCleaner.Clean(dirtyFile, CleanFile);

            string StringFile = File.ReadAllText(CleanFile);
            string[] arr = StringFile.Split("\r\n", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            Console.WriteLine(BalanceStats.FindHighestBalanceEver(arr));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(BalanceStats.FindPersonWithBiggestLoss(arr));
            // - FindRichestPerson
            Console.WriteLine(BalanceStats.FindRichestPerson(arr));
            // - FindMostPoorPerson
            Console.WriteLine(BalanceStats.FindMostPoorPerson(arr));
            Console.WriteLine(TextTable.Build("Hello", 0));
            Console.WriteLine(TextTable.Build($"Hello{Environment.NewLine}World!", 0));
            Console.WriteLine(TextTable.Build("Hello", 4));
        }
    }
}
