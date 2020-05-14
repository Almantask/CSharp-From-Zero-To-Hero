using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.CvsProcessors
{
    public static class Daily
    {
        private static CultureInfo CurrentCultureInfo => CultureInfo.GetCultureInfo("lt-LT");
        
        public static string CheckShopDailyByName(IEnumerable<Transaction> transactions, string storeName)
        {
            var data = transactions
                .Where(n => n.Shop.Equals(storeName))
                .GroupBy(n => n.DateTime.Day,
                    (date, values) =>
                    {
                        var transaction = values.ToList();
                        return new DailySummary
                        (
                            transaction.First().DateTime.ToString("dddd", CultureInfo.GetCultureInfo("en-US")),
                            transaction.Select(n => n.Price).Sum()
                        );
                    });
            
            return GetShopSummary(data);
        }

        private static string GetShopSummary(IEnumerable<DailySummary> data)
        {
            var summary = new StringBuilder();
            summary.AppendLine("Day, Earned");

            foreach (var dailySummary in data)
            {
                var day = dailySummary.Day;
                var earn = dailySummary.Earn.ToString("C", CurrentCultureInfo);

                summary.AppendLine($"{day}, \"{earn}\"");
            }

            return summary.ToString();
        }

        // TODO: Useful but not for this class
        // private static string GetShopSummary(List<Transaction> data)
        // {
        //     var summary = new StringBuilder();
        //     summary.AppendLine("City, Street, Item, DateTime, Price");
        //
        //     // Springfield, HoloPapap 2, Sausage, 2020-01-05T20:00:00Z, "8,00 €"
        //     foreach (var transaction in data)
        //     {
        //         var city = transaction.City;
        //         var street = transaction.Street;
        //         var item = transaction.Item;
        //         var dateTime = transaction.DateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
        //         var price = transaction.Price.ToString("C", CurrentCultureInfo);
        //
        //         summary.AppendLine($"{city}, {street}, {item}, {dateTime}, \"{price}\"");
        //     }
        //
        //     return summary.ToString();
        // }
    }
}