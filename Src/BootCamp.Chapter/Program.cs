using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ImportTransactionsData dataInput = new ImportTransactionsData();
            dataInput.ImportTransactionsDataT(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\Transactions.csv");
            Console.ReadKey();
        }
    }
}
