using System;
using System.Text;

namespace BootCamp.Chapter
{
    internal static class Program
    {
        private static string[] MyBalances => new[]
        {
            "Tom, 1, 2, 3, 4",
            "Katherine, 1, 2, 3, 4",
            "Bill, 1, 2, 3, 4",
            "Catie, 1, 2, 3, 4"
        };

        private static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            //Console.WriteLine("");
            BalanceStats balanceStats = new BalanceStats(MyBalances);
            Console.WriteLine(balanceStats.FindHighestBalanceEver());
        }
    }
}