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

            foreach (var row in rows)
            {
                if (Transaction.TryParse(row, out Transaction transaction))
                {
                    transactions.Add(transaction);
                    row.Print(CsvDelimiter.Comma);
                }
            }

            //Console.ReadLine();
            Query.Shop(transactions, "Wallmart");
            Query.Time(transactions, new TimeInterval(new TimeSpan(0, 0, 0), new TimeSpan(23, 59, 59)));

            //var test = from row in rows
            //           where row[0] == "Kwiki Mart"
            //           select row;

            //foreach (var row in test)
            //{
            //    row.Print(CsvDelimiter.Comma);
            //}

            //foreach (var shop in shops)
            //{
            //    shop.Print(CsvDelimiter.Comma);
            //}
        }
    }
}