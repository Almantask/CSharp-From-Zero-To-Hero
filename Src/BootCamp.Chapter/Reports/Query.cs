using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Csv;

namespace BootCamp.Chapter
{
    public static class Query
    {
        private const string fileExtension = ".csv";

        public static void Shop(List<Transaction> transactions, string name)
        {
            var shopFileName = $"{name}{fileExtension}";
            var shopHeader = new CsvRow { "City", "Street", "Item", "DateTime", "Price" };

            var queryResult = from transaction in transactions
                              where transaction.Shop.Name == name
                              select new CsvRow
                              {
                                 transaction.Shop.Address.City,
                                 transaction.Shop.Address.Street,
                                 transaction.Item.Name,
                                 transaction.DateTime.ToString(Culture.Output.DateTimeFormat.FullDateTimePattern),
                                 transaction.Item.Price.ToString("C", Culture.Output.NumberFormat).AddQuotes()
                              };

            var shopWriter = new CsvWriter(shopFileName, CsvDelimiter.Comma, true);
            shopWriter.WriteAllRows(queryResult, shopHeader);
        }

        public static void Time(List<Transaction> transactions, TimeInterval timeInterval)
        {
            var timeFileName = string.Empty;
            var fullDay = new TimeInterval(new TimeSpan(0, 0, 0), new TimeSpan(23, 59, 59));
            var nightTime = new TimeInterval(new TimeSpan(20, 0, 0), new TimeSpan(23, 59, 59));

            var timeHeader = new CsvRow { "Hour", "Count", "Earned" };

            if (timeInterval.Equals(fullDay))
            {
                timeFileName = $"FullDay{fileExtension}";
            }
            else if (timeInterval.Equals(nightTime))
            {
                timeFileName = $"Night{fileExtension}";
            }
            else
            {
                timeFileName = $"{timeInterval.Start}-{timeInterval.End}{fileExtension}";
            }

            var queryResult = from transaction in transactions
                              where timeInterval.Contains(transaction.DateTime.TimeOfDay)
                              orderby transaction.DateTime.Hour ascending
                              select new CsvRow { transaction.DateTime.Hour.ToString("00"),
                                  transaction.Item.Price.ToString("C", Culture.Output.NumberFormat).AddQuotes() };

            var timeWriter = new CsvWriter(timeFileName, CsvDelimiter.Comma, true);
            timeWriter.WriteAllRows(queryResult, timeHeader);
        }
    }
}