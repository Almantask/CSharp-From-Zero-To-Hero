using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Address
    {
        public string Recipient { get; }
        public string Street { get; }
        public string PostalCode { get; }

        public Address(string recipient, string street, string town, string county, string postalCode, string country, string houseNumber = "")
        {
            Recipient = recipient;
            Street = street;
            PostalCode = postalCode; 
        }

        public static bool TryParse(string addressString, out Address address)
        {
            address = default;
            
            if (String.IsNullOrEmpty(addressString))
            {
                return false; 
            }

            var splittedAdress = addressString.Split(Environment.NewLine);

            if (splittedAdress.Length != 7)
            {
                return false; 
            }

            address = new Address(splittedAdress[0], splittedAdress[1], splittedAdress[2], splittedAdress[3], splittedAdress[4], splittedAdress[5]); 

            return true; 
        }

        public static bool operator ==(Address address1, Address address2)
        {
            return (address1.Recipient == address2.Recipient) && (address1.Street == address2.Street) && (address1.PostalCode == address2.PostalCode); 
        }

        public static bool operator !=(Address address1, Address address2)
        {
            return !(address1 == address2); 
        }
    }
}
