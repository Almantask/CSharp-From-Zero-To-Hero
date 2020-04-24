using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Csv;

namespace BootCamp.Chapter
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            DemoCsv();
        }

        private static void DemoCsv()
        {
            var testReader = new CsvReader("Input/Transactions.csv", CsvDelimiter.Comma, true);
            var rows = testReader.ReadAllRows();
            var transactions = new List<Transaction>();

            rows.Enumerate(x => x.Print(CsvDelimiter.Colon));

            foreach (var row in rows)
            {
                _ = Transaction.TryParse(row, out Transaction transaction);
                transactions.Add(transaction);
            }

            Query.Shop(transactions, "Wallmart");
            Query.Shop(transactions, "Kwiki Mart");
            Query.Time(transactions, new TimeInterval(new TimeSpan(19, 00, 00), new TimeSpan(23, 59, 59)));
        }
    }
}