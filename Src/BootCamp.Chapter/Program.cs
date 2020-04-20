using System;
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

            var testReader = new CsvReader("Input/Transactions.csv", CsvDelimiter.Comma, true);
            var testWriter = new CsvWriter("test_write.csv", CsvDelimiter.Pipe, true);

            var rows = testReader.ReadAllRows();

            //foreach (var row in rows)
            //{
            //    row.Print(CsvDelimiter.Pipe);
            //}

            testWriter.WriteRows(rows.Skip(500));
        }
    }
}