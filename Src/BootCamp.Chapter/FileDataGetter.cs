using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class FileDataGetter
    {
        public void Run()
        {
            string corruptFile = GetPathToCorruptFile(GetPathToWorkFolder());
            string cleanedFile = GetPathToCleanedFile(GetPathToWorkFolder());

            FileCleaner fileCleaner = new FileCleaner();
            fileCleaner.Clean(corruptFile, cleanedFile);

            TextTable textTable = new TextTable();
            BalanceStats balanceStats = new BalanceStats();

            // - FindHighestBalanceEver
            Console.WriteLine(textTable.Build(balanceStats.FindHighestBalanceEver(fileCleaner.AccountArray), 3));
            // - FindPersonWithBiggestLoss
            Console.WriteLine(textTable.Build(balanceStats.FindPersonWithBiggestLoss(fileCleaner.AccountArray), 3));
            // - FindRichestPerson
            Console.WriteLine(textTable.Build(balanceStats.FindRichestPerson(fileCleaner.AccountArray), 3));
            // - FindMostPoorPerson
            Console.WriteLine(textTable.Build(balanceStats.FindMostPoorPerson(fileCleaner.AccountArray), 3));
        }

        private string GetPathToWorkFolder()
        {
            string path = Directory.GetCurrentDirectory();
            for (int i = 0; i < 3; i++)
            {
                path = Directory.GetParent(path).ToString();
            }
            return path;
        }
        private string GetPathToCorruptFile(string pathToWorkFolder)
        {
            return (pathToWorkFolder + string.Format(@"\Input\Balances.corrupted"));
        }
        private string GetPathToCleanedFile(string pathToWorkFolder)
        {
            return (pathToWorkFolder + string.Format(@"\Input\BalancesClean.txt"));
        }
    }
}
