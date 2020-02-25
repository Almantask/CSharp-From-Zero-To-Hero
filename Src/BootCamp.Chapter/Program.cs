using System;
using System.IO;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string CorruptedBalanceFile = @"..\..\..\Input\Balances.corrupted";
        private const string FixedBalanceFile = @"..\..\..\Input\Balances.fixed";

        static void Main(string[] args)
        {
            var cleanTable = new CleanTable(CorruptedBalanceFile, FixedBalanceFile);
            cleanTable.Clean();
        }
    }


}
