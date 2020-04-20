using BootCamp.Chapter.Csv;
using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        public Shop Shop { get; set; }
        public Item Item { get; set; }
        public DateTime DateTime { get; set; }

        public static bool TryParse(CsvRow input, out Transaction transaction)
        {
            transaction = new Transaction();
            if (input?.Count == 0)
            {
                return false;
            }

            transaction.Shop.Name = input[0];
            transaction.Shop.Address.City = input[1];
            transaction.Shop.Address.Street = input[2];
            transaction.Item.Name = input[3];
            transaction.DateTime = DateTime.Parse(input[4]);
            transaction.Item.Price = decimal.Parse(input[5]);

            return true;
        }
    }
}