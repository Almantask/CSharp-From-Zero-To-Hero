using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parser = new TransactionJsonParser(@"Input/Transactions.json");
            Console.WriteLine("gelukt");
        }
    }
}
