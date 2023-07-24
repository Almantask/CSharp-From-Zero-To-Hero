using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;

namespace BootCamp.Chapter
{
	public class Transaction
	{
		public string Shop { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string Item { get; set; }
		public DateTime DateTime { get; set; }
		public decimal Price { get; set; }

		public Transaction(string shop, string city, string street, string item, DateTime dateTime, decimal price)
		{
			Shop = shop;
			City = city;
			Street = street;
			Item = item;
			DateTime = dateTime;
			Price = price;
		}

		public static IEnumerable<Transaction> ToTransaction(string filePath)
		{
			if (!File.Exists(filePath)) throw new NoTransactionsFoundException();

			List<Transaction> list = new List<Transaction>();
			using (TextFieldParser parser = new TextFieldParser(filePath))
			{
				//Error if file is empty
				if (parser.EndOfData) throw new NoTransactionsFoundException();

				//Set delimiter
				parser.SetDelimiters(",");

				//Ignore first line as it's just the property names
				parser.ReadLine();

				//Convert remaining lines to Transaction objects
				while (!parser.EndOfData)
				{
					string[] fields = parser.ReadFields();
					//Error if we don't have 6 fields
					if (fields.Length != 6) throw new FormatException($"Line: {string.Join(",", fields)} does not have the correct number of fields.");

					//Convert to correct types
					//[0] Shop
					string shop = fields[0];
					//[1] City
					string city = fields[1];
					//[2] Street
					string street = fields[2];
					//[3] Item
					string item = fields[3];
					//[4] DateTime
					DateTimeOffset dateTimeOffset;
					if (!DateTimeOffset.TryParse(fields[4], out dateTimeOffset)) throw new FormatException($"Line: {string.Join(",", fields)} does not have a correct DateTime for {nameof(Transaction.DateTime)}.");
					DateTime dateTime = dateTimeOffset.DateTime;
					//[5] Price
					decimal price;
					if (!decimal.TryParse(fields[5], NumberStyles.Any, CultureInfo.GetCultureInfo("fr-FR"), out price)) throw new FormatException($"Line: {string.Join(",", fields)} does not have a correct decimal for {nameof(Transaction.Price)}.");

					//Create Transaction object
					list.Add(new Transaction(shop, city, street, item, dateTime, price));
				}
			}

			return list;
		}
	}
}
