using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class PostOffice
    {
        public string Location;
        public List<Address> PostAddresses;
        public int DuplicateCount;

        public PostOffice(string location)
        {
            Location = location;
            PostAddresses = new List<Address>();
            DuplicateCount = 0;
        }

        public void AddPostalAddress(Address address)
        {
            PostAddresses.Add(address);
        }
    }
}
