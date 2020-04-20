using System;
using System.Linq;
using BootCamp.Chapter.Csv;

namespace BootCamp.Chapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var testWriter = new CsvWriter("TestData/write_test.csv", CsvDelimiter.Comma, true);
            var testReader = new CsvReader("Input/Transactions.csv", CsvDelimiter.Comma, true);

            var readerRows = testReader.ReadAllRows();

            testWriter.WriteRows(readerRows.Skip(100), testReader.Header);
        }
    }
}