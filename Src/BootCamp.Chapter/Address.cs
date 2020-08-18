using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class Address
    {
        public string Recipient { get; }
        public string Street { get; }
        private const int ExpectedLengthOfAddress = 7;

        public Address(string recipient, string street, string town, string county, string postalCode, string country, string houseNumber = "")
        {
            Recipient = recipient;
            Street = street;
        }

        public static bool TryParse(string addressString, out Address address)
        {
            address = default;
            string[] tempString = addressString?.Split(Environment.NewLine);
            // Can refine to only check if key elements are missing i.e PostCode, Streetname and Building Number/Name
            // Unsure what the is the best action. Either throw a new exception and capture the error or just return false? Will return false for benefit of tests
            if (tempString?.Length != ExpectedLengthOfAddress) return false;

            address = new Address(tempString[0], tempString[1], tempString[2], tempString[3], tempString[4], tempString[5]);
            return true;
        }

        public static bool operator ==(Address address1, Address address2)
        {
            return address1?.Recipient == address2?.Recipient && address1?.Street == address2?.Street;
        }

        public static bool operator !=(Address address1, Address address2)
        {
            return address1?.Recipient != address2?.Recipient && address1?.Street != address2?.Street;
        }
    }
}
