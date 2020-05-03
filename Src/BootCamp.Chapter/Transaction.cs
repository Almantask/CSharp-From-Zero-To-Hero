using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        private enum fields
        {
            name,
            city,
            street,
            item,
            dateTime,
            price
        }

        // Shop,City,Street,Item,DateTime,Price
        private string ShopName { get; }

        private string City { get; }
        private string Street { get; }
        private string Item { get; }
        private DateTime DateTime { get; }
        private decimal Price { get; }

        private Transaction(string name, string city, string street, string item, DateTime dateTime, decimal price)
        {
            ShopName = name;
            City = city;
            Street = street;
            Item = item;
            DateTime = dateTime;
            Price = price;
        }

        public static bool TryParse(string input, out Transaction transaction)
        {
            transaction = default;

            string[] splitInput = input.Split(',');

            //Trim all the Strings
            for (int i = 0; i < splitInput.Length; i++)
            {
                splitInput[i] = splitInput[i].Trim();
            }

            //Price gets Split into 2 so i reattach them
            splitInput[(int)fields.price] = splitInput[(int)fields.price] + "," + splitInput[(int)fields.price + 1];

            DateTime sellDateTime;
            if (!DateTime.TryParse(splitInput[(int)fields.dateTime], out sellDateTime))
            {
                Console.WriteLine($"Could not Read {nameof(DateTime)}");
                return false;
            }

            decimal price;
            if (!IsThisADecimal(splitInput[(int)fields.price], out price))
            {
                Console.WriteLine($"Could not Read {nameof(Price)}");
                return false;
            }

            transaction = new Transaction(
                splitInput[(int)fields.name],
                splitInput[(int)fields.city],
                splitInput[(int)fields.street],
                splitInput[(int)fields.item],
                sellDateTime,
                price);
            return true;
        }

        private static bool IsThisADecimal(string price, out decimal number)
        {
            number = default;

            price = price.Replace("\"", "");
            price = price.Replace("€", "");
            price = price.Trim();

            if (Decimal.TryParse(price, out number))
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return $"{ShopName} - {City} - {Street} sold {Item} at {DateTime} for {Price.ToString("C2", CultureInfo.CurrentCulture)}";
        }
    }
}