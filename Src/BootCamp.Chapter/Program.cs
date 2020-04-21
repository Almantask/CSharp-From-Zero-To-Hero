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
            var testWriter = new CsvWriter("test_write.csv", CsvDelimiter.Pipe, true);
            var rows = testReader.ReadAllRows();
            var transactions = new List<Transaction>();

            foreach (var row in rows.Skip(950))
            {
                if (Transaction.TryParse(row, out Transaction transaction))
                {
                    transactions.Add(transaction);
                    //row.Print(CsvDelimiter.Comma);
                }
            }
            //Console.ReadLine();

            var citys = from transaction in transactions
                        where transaction.Shop.Address.City == "London"
                        select new { Shop = transaction.Shop.Name, Item = transaction.Item.Name, Price = transaction.Item.Price, DateTime = transaction.DateTime };
            var test = from row in rows
                       where row[0] == "Lidl"
                       select row;

            test.Print(CsvDelimiter.Colon);
        }
    }
}