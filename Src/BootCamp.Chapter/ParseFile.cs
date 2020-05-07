using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class ParseFile
    {
        public static List<Address> addressList = new List<Address>();

        public static List<Address> Parse()
        {
            var file = "Addresses.txt";
            var contents = File.ReadAllText(@$"{file}");
            var addresses = contents.Split($"{Environment.NewLine}{Environment.NewLine}");

            foreach (var address in addresses)
            {
                var isValid = Address.TryParse(address, out Address validAddress);
                if (isValid)
                {
                    addressList.Add(validAddress);
                }
            }

            return addressList;
        }
    }
}