using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Address
    {
        public string Recipient { get; }
        public string Street { get; }

        public Address(string recipient, string street, string town, string county, string postalCode, string country, string houseNumber = "")
        {
            Recipient = recipient;
            Street = street;
        }

        public static bool TryParse(string addressString, out Address address)
        {
            address = default;
            return false;
        }
    }
}
