using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Csv;

namespace BootCamp.Chapter
{
    public static class Query
    {
        public static void Shop(List<Transaction> transactions, string name)
        {
            var shopFileName = name + ".csv";
            var shopHeader = new CsvRow { "City", "Street", "Item", "DateTime", "Price" };

            var shops = from transaction in transactions
                        where transaction.Shop.Name == name
                        select new CsvRow
                        {   transaction.Shop.Address.City,
                            transaction.Shop.Address.Street,
                            transaction.Item.Name,
                            transaction.DateTime.ToString(Culture.Output.DateTimeFormat.FullDateTimePattern),
                            transaction.Item.Price.ToString("C",Culture.Output.NumberFormat).AddQuotes()
                        };

            var shopWriter = new CsvWriter(shopFileName, CsvDelimiter.Comma, true);

            shopWriter.WriteAllRows(shops, shopHeader);
        }
    }
}