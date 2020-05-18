using System;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArgsReader.Read(args);

            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //TestArgs();
            //TestTransactionTryParse();
            //TestReportsManager();
        }

        private static void TestArgs()
        {
            string[] command = new string[] { @"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Tests\BootCamp.Chapter.Tests\Input\Transactions.csv", "time", "test.csv" };
        }

        private static void TestReportsManager()
        {
            var reports = ReportsManager.ReadTransactionFile(@"C:\Users\Max\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\bin\Debug\netcoreapp3.1\Input\Transactions.csv");

            foreach (var report in reports)
            {
                Console.WriteLine(report.ToString());
            }
        }

        private static void TestTransactionTryParse()
        {
            string testString = "Lidl,New York, Freedom, Bread -Granary Small Pull,2020 - 04 - 25T10: 32:16Z,\"€64,90\"";

            if (Transaction.TryParse(testString, out Transaction transaction))
            {
                Console.WriteLine("Succeded!");
                Console.WriteLine(transaction.ToString());
            }
        }
    }
}