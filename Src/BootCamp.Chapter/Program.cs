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
            if (args.Length > 0)
            {
                throw new InvalidCommandException("no arguments provided");
            }

            Console.OutputEncoding = Encoding.Unicode;
            DemoCsv();
        }

        private static void DemoCsv()
        {
            var testReader = new CsvReader("Input/Transactions.csv", CsvDelimiter.Comma, true);
            var rows = testReader.ReadAllRows();
            var transactions = PopulateTransactions(rows);

            rows.Enumerate(x => x.Print(CsvDelimiter.Colon));

            Query.Shop(transactions, "Wallmart");
            Query.Shop(transactions, "Kwiki Mart");
            Query.Time(transactions, new TimeInterval(new TimeSpan(00, 00, 00), new TimeSpan(23, 59, 59)));

            var reader = new CsvReader("FullDay.csv", CsvDelimiter.Comma, false, false);
            var readerRows = reader.ReadAllRows();
            readerRows.Enumerate(x => x.Print(CsvDelimiter.Pipe));
        }

        private static List<Transaction> PopulateTransactions(IEnumerable<CsvRow> rows)
        {
            var transactions = new List<Transaction>();
            foreach (var row in rows)
            {
                _ = Transaction.TryParse(row, out Transaction transaction);
                transactions.Add(transaction);
            }
            return transactions;
        }
    }
}