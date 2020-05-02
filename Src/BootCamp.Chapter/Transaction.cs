using System;
using System.Collections.Generic;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string SoldItem { get; set; }
        public DateTime TimeWhenSold { get; set; }
        public decimal TotalPrice { get; set; }

        internal static bool TryParse(string input, out Transaction transaction)
        {

            var splittedData = mySplit(input); 
            var isValid = DateTime.TryParse(splittedData[4], out DateTime date);

            if (!isValid)
            {
                Console.WriteLine("Invalid date");
            }

            var moneyText = splittedData[5].Replace("\"", "");

            isValid = decimal.TryParse(moneyText, NumberStyles.Currency,CultureInfo.CurrentCulture.NumberFormat, out decimal price);

            if (!isValid)
            {
                Console.WriteLine("Invalid price");
            }

            transaction = new Transaction
            {
                ShopName = splittedData[0],
                City = splittedData[1],
                Street = splittedData[2],
                SoldItem = splittedData[3],
                TimeWhenSold = date,
                TotalPrice = price
            };

            return true;
        }

        private static string[] mySplit(string input)
        {
            List<string> tokens = new List<string>();

            int last = -1;
            int current = 0;
            bool inText = false;

            while (current < input.Length)
            {
                switch (input[current])
                {
                    case '"':
                        inText = !inText; break;
                    case ',':
                        if (!inText)
                        {
                            tokens.Add(input.Substring(last + 1, (current - last)).Trim(' ', ','));
                            last = current;
                        }
                        break;
                    default:
                        break;
                }
                current++;
            }

            if (last != input.Length - 1)
            {
                tokens.Add(input.Substring(last + 1).Trim());
            }

            return tokens.ToArray();

        }
    }
}