using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.Processors
{
    public static class DailyProcessor
    {
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
                var earn = dailySummary.Earn.ToString("C", Config.CultureInfo);

                summary.AppendLine($"{day}, \"{earn}\"");
            }

            return summary.ToString();
        }
    }
}
