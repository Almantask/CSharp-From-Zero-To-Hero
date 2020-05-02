using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parser = new TransactionCVSParser(@"Input/Transactions.csv");
            TimeStatics.CalculateTimeReport(parser.Transactions); 
        }
    }
}
