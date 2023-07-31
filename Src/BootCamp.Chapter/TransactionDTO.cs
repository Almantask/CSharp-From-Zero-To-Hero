using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BootCamp.Chapter
{
	public class TransactionDTO
	{
		public string Shop { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string Item { get; set; }
		public DateTime DateTime { get; set; }
		public string Price { get; set; }
	}
	public class TransactionsDTO
	{
		[JsonProperty("Transaction")]
		public List<TransactionDTO> Transactions { get; set; }
	}
	public class JsonTransactionsDTO
	{
		[JsonProperty("Transactions")]
		public TransactionsDTO TransactionsDTO { get; set; }
	}
}
