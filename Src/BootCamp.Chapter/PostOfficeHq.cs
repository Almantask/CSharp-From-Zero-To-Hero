using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class PostOfficeHq
    {
        public List<PostOffice> ListOfPostOffices = new List<PostOffice>();
        private List<Address> _addresses = new List<Address>();
        private string _path = "path";
        private StringBuilder stringBuilder = new StringBuilder();

        private void AddressesParser()
        {
            string[] lines = new string[7];
            using ( var reader = new StreamReader(_path))
            {
                string line = reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    while (line != null)
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            lines[i] = line;
                            line = reader.ReadLine();
                        }
                        AppendAddress(lines);
                    }
                }
            }
        }

        private void AppendAddress(string[] lines)
        {
            _addresses.Add(new Address(lines[0], lines[1], lines[2], lines[3], lines[4], lines[5], lines[6]));
        }

        private void AssignPostOffices()
        {
            foreach (var address in _addresses)
            {
                if (DuplicateCheck(address))
                {
                    ListOfPostOffices.Add(new PostOffice(address.Town));
                }
            }
        }

        private void AddAddressesToPostOffice()
        {
            // get address town
            // retrieve the post office for that town
            // check to see whether the post office in that town has any post for that address
            // if true, increment duplication count
            // if false, add address to post office
        }

        private bool DuplicateCheck(Address address)
        {
            return ListOfPostOffices.Any(x => x.Location == address.Town);
        }
    }
}
