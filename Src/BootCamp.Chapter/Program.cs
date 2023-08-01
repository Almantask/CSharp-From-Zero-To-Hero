using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
	class Program
	{
		private static readonly string FILE_PATH = "Addresses.txt";

		static void Main(string[] args)
		{
			//Read Address file
			string fileText = File.ReadAllText(FILE_PATH);
			//Split into each address entry
			//Each address entry is seperated by a new line (1st newline is the end of the entry, 2nd newline is the line between entries)
			string[] addressTexts = fileText.Split(Environment.NewLine + Environment.NewLine);
			//Parse into address objects
			List<Address> addresses = new List<Address>();
			foreach (string addressText in addressTexts)
			{
				Address address;
				bool isAddress = Address.TryParse(addressText, out address);
				if (isAddress)
				{
					addresses.Add(address);
				}
			}

			//Get duplicate addresses
			var dupAddresses = from address in addresses
							   group address by address into addressGroup
							   select new
							   {
								   DuplicateAddress = addressGroup.Key,
								   DuplicateCount = addressGroup.Count()
							   };
			//Get total count per postal code
			var postalGroupDups = from address in dupAddresses
								  group address by address.DuplicateAddress.PostalCode into postalGroup
								  select new
								  {
									  PostalCode = postalGroup.Key,
									  DupCount = postalGroup.Sum(p => p.DuplicateCount)
								  };
			//Get highest dup count
			int biggestDupCount = postalGroupDups.Max(p => p.DupCount);
			//Get all postal codes with highest dup count (if more than 1)
			var biggestDupCountPostals = from postalCode in postalGroupDups
										 where postalCode.DupCount == biggestDupCount
										 select postalCode.PostalCode;
			string resultPostals = String.Join(", ", biggestDupCountPostals);

			//Write results to console
			Console.WriteLine($"Postal code(s) with the most duplicate addresses: {resultPostals}");
			Console.ReadLine();
		}
	}
}
