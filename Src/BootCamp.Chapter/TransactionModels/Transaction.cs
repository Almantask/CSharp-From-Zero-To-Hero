using BootCamp.Chapter.Csv;
using BootCamp.Chapter.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        public Shop Shop { get; set; }
        public Item Item { get; set; }
        public DateTime DateTime { get; set; }

        public Transaction()
        {
        }

        public Transaction(Shop shop, Item item, DateTime dateTime)
        {
            Shop = shop;
            Item = item;
            DateTime = dateTime;
        }

        public string ToStringFormated(CsvDelimiter delimiter)
        {
            return $"{Shop.Name}{(char)delimiter}{Shop.Address.City}{(char)delimiter}" +
                $"{Shop.Address.Street}{(char)delimiter}{Item.Name}{(char)delimiter}" +
                $"{DateTime.ToString(Culture.Output.DateTimeFormat.FullDateTimePattern)}" +
                $@"{(char)delimiter}""{Item.Price.ToString("C", Culture.Output.NumberFormat)}""";
        }

        public static bool TryParse(CsvRow input, out Transaction transaction)
        {
            transaction = new Transaction();

            if (!AreFieldsValid(input))
            {
                return false;
            }

            transaction.Shop = new Shop { Name = input[0].Trim(), Address = new Address { City = input[1].Trim(), Street = input[2].Trim() } };
            transaction.Item = new Item { Name = input[3].Trim(), Price = decimal.Parse(input[5].Trim(), NumberStyles.Currency, Culture.Input) };
            transaction.DateTime = DateTime.ParseExact(input[4].Trim(), Culture.Input.DateTimeFormat.FullDateTimePattern, Culture.Input).ToUniversalTime();

            return true;
        }

        private static bool AreFieldsValid(CsvRow input)
        {
            foreach (var field in input)
            {
                return field.IsValid();
            }
            return false;
        }
    }
}