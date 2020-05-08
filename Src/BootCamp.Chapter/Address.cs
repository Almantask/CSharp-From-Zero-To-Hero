using System;

namespace BootCamp.Chapter
{
    public class Address
    {
        private const int totalMandotoryProperties = 7;

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

            if (splittedAdress.Length != totalMandotoryProperties)
            {
                return false;
            }

            address = new Address(splittedAdress[0], splittedAdress[1], splittedAdress[2], splittedAdress[3], splittedAdress[5], splittedAdress[6]);

            return true;
        }

        public override bool Equals(object obj)
        {
            return obj is Address address &&
                   Recipient == address.Recipient &&
                   Street == address.Street &&
                   PostalCode == address.PostalCode;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Recipient, Street, PostalCode);
        }

        public static bool operator ==(Address address1, Address address2)
        {
            return (address1.Recipient == address2.Recipient)
                && (address1.Street == address2.Street)
                && (address1.PostalCode == address2.PostalCode);
        }

        public static bool operator !=(Address address1, Address address2)
        {
            return !(address1 == address2);
        }
    }
}