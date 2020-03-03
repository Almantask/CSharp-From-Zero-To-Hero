using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        private const string CorruptedBalanceFile = @"..\..\..\Input\Balances.corrupted";
        private const string FixedBalanceFile = @"..\..\..\Input\Balances.fixed";

        static void Main(string[] args)
        {
            FileCleaner.Clean(CorruptedBalanceFile, FixedBalanceFile);
        }
    }
}
