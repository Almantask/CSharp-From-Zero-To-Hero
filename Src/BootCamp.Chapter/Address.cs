using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public class Address
	{
		public string Recipient { get; }
		public string Street { get; }
		public string Town { get; }
		public string County { get; }
		public string PostalCode { get; }
		public string Country { get; }
		public string HouseNumber { get; }

		public Address(string recipient, string street, string town, string county, string postalCode, string country, string houseNumber = "")
		{
			Recipient = recipient;
			Street = street;
			Town = town;
			County = county;
			PostalCode = postalCode;
			Country = country;
			HouseNumber = houseNumber;
		}

		public static bool TryParse(string addressString, out Address address)
		{
			address = default;

			//Split string by lines
			string[] addressFields = addressString.Split(Environment.NewLine);
			//Return false if there aren't 7 lines
			if (addressFields.Length != 7) return false;
			//Setup values
			string recipient = addressFields[0];
			//BuildingName = addressFields[2]?//houseNumber isn't defined in the HW and this field never shows a number.
			string street = addressFields[1];//Unit Test says this is the street, but HW website says it's the buildingName
			string town = addressFields[3];
			string county = addressFields[4];
			string postalCode = addressFields[5];
			string country = addressFields[6];

			//Create new Address object
			address = new Address(recipient, street, town, county, postalCode, country);
			return true;
		}

		public static bool operator ==(Address leftAddress, Address rightAddress)
		{
			return leftAddress.Recipient.Equals(rightAddress.Recipient) &&
				leftAddress.Street.Equals(rightAddress.Street) &&
				leftAddress.Town.Equals(rightAddress.Town) &&
				leftAddress.County.Equals(rightAddress.County) &&
				leftAddress.PostalCode.Equals(rightAddress.PostalCode) &&
				leftAddress.Country.Equals(rightAddress.Country) &&
				leftAddress.HouseNumber.Equals(rightAddress.HouseNumber);
		}
		public static bool operator !=(Address leftAddress, Address rightAddress)
		{
			return !(leftAddress == rightAddress);
		}
		public override bool Equals(object obj)
		{
			return this == (Address)obj;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Recipient, Street, Town, County, PostalCode, Country, HouseNumber);
		}
	}
}
