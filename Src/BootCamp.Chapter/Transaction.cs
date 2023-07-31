using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace BootCamp.Chapter
{
	public class Transaction
	{
		public string Shop { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string Item { get; set; }
		public DateTime DateTime { get; set; }
		private string _price;
		public string Price
		{
			get { return _price; }
			set
			{
				_price = value;
				OnPriceChange();
			}
		}
		public decimal PriceValue { get; private set; }
		
		private void OnPriceChange()
		{
			decimal newValue;
			if (!decimal.TryParse(Price, NumberStyles.Any, CultureInfo.GetCultureInfo("fr-FR"), out newValue)) throw new FormatException($"{nameof(Transaction.Price)}: {Price} does not have correct decimal formatting.");
			PriceValue = newValue;
		}

		public Transaction(string shop, string city, string street, string item, DateTime dateTime, string price)
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
					string price = fields[5];

					//Create Transaction object
					list.Add(new Transaction(shop, city, street, item, dateTime, price));
				}
			}

			return list;
		}
	}
}