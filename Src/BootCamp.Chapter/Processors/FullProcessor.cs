using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Objects;

namespace BootCamp.Chapter.Processors
{
    public static class FullProcessor
    {
        public static void ExportFullSummary(IEnumerable<Transaction> transactions)
        {
            var data = transactions
                .GroupBy(n => n.Shop)
                .Select(n => n.ToList());

            foreach (var transaction in data)
            {
                GetShopSummary(transaction);
            }
        }
        
        private static void GetShopSummary(List<Transaction> shop)
        {
            var storeName = shop.FirstOrDefault()?.Shop;
            var summary = new StringBuilder();
            summary.AppendLine("City, Street, Item, DateTime, Price");
            
            foreach (var transaction in shop)
            {
                var city = transaction.City;
                var street = transaction.Street;
                var item = transaction.Item;
                var dateTime = transaction.DateTime.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'Z'");
                var price = transaction.Price.ToString("C", Config.CultureInfo);
        
                summary.AppendLine($"{city}, {street}, {item}, {dateTime}, \"{price}\"");
            }

            if (storeName != null)
            {
                File.WriteAllText($"{storeName}.csv", summary.ToString());
            }
        }
    }
}
