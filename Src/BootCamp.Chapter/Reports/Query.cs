using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using CsvLib;

namespace BootCamp.Chapter
{
    public static class Query
    {
        private const string fileExtension = ".csv";
        private static readonly string timeSeparator = Culture.Output.DateTimeFormat.TimeSeparator;

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
                                 transaction.DateTime.ToString(Culture.Output),
                                 transaction.Item.Price.ToString("C", Culture.Output).AddQuotes()
                              };

            var shopWriter = new CsvWriter(shopFileName, CsvDelimiter.Comma, true);
            shopWriter.WriteAllRows(queryResult, shopHeader);
        }

        public static void Time(List<Transaction> transactions, TimeInterval timeInterval)
        {
            var timeFileName = string.Empty;
            var fullDay = new TimeInterval(new TimeSpan(0, 0, 0), new TimeSpan(23, 59, 59));
            var nightTime = new TimeInterval(new TimeSpan(19, 59, 59), new TimeSpan(23, 59, 59));

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
                timeFileName = $"{timeInterval.Start.ToString().Replace(timeSeparator, "")}-{timeInterval.End.ToString().Replace(timeSeparator, "")}{fileExtension}";
            }

            var transactionsByHours = transactions.ToLookup(x => x.DateTime.Hour);
            var earningsByHour = GetEarningsByHour(transactions, timeInterval);

            var query = from earning in earningsByHour
                        select new
                        {
                            Hour = earning.Key,
                            Count = transactionsByHours[earning.Key]?.Count(),
                            Earned = earningsByHour[earning.Key]?.AverageOrZero()
                        };

            var rushHour = $"Rush hour: {query.OrderByDescending(field => field.Earned).First()?.Hour}";

            var csvResult = from earning in query
                            select new CsvRow {
                             earning.Hour.ToString("00"),
                             earning.Count.ToString(),
                             earning.Earned?.ToString("C", Culture.Output).AddQuotes() };

            var timeWriter = new CsvWriter(timeFileName, CsvDelimiter.Comma, true, true);
            timeWriter.WriteAllRows(csvResult, timeHeader, rushHour);
        }

        // this part eluded me until I saw a PR from a mentor and I shamelessly stole it
        private static Dictionary<int, List<decimal>> GetEarningsByHour(List<Transaction> transactions, TimeInterval timeInterval)
        {
            var earningsByHour = new Dictionary<int, List<decimal>>(
                Enumerable.Range(timeInterval.Start.Hours, timeInterval.TotalHours)
                    .Select(x => new KeyValuePair<int, List<decimal>>(x, new List<decimal>())
                )
            );

            var transactionsByDay = transactions.GroupBy(record => record.DateTime);

            foreach (var daysTransactions in transactionsByDay)
            {
                var queryByHour = daysTransactions.GroupBy(record => record.DateTime.Hour);
                foreach (var hour in queryByHour)
                {
                    earningsByHour[hour.Key]?.Add(hour.Sum(record => record.Item.Price));
                }
            }

            return earningsByHour;
        }
    }
}