using System;
using System.Text;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print each of the statistical output using Text Table with padding 3:
            // - FindHighestBalanceEver
            // - FindPersonWithBiggestLoss
            // - FindRichestPerson
            // - FindMostPoorPerson
            string[] arr = { "Tom, 1", "Gillie, 1", "Agnes, 1" };
            
            Console.WriteLine(BalanceStats.FindRichestPerson(arr));
            
        }

    }
}
