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
        private string _path = @"C:\Users\matth\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Addresses.txt";

        public PostOfficeHq()
        {
            AddressesParser();
            AssignPostOffices();
            AddAddressesToPostOffice();
        }

        private void AddressesParser()
        {
            string[] lines = new string[7];
            using ( var reader = new StreamReader(_path))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (line != "")
                    {
                        for (int i = 0; i < lines.Length; i++)
                        {
                            lines[i] = line;
                            line = reader.ReadLine();
                        }
                        AppendAddress(lines);
                        lines = new string[7];
                    }
                    else
                    {
                        line = reader.ReadLine();
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
                if (!DoesPostOfficeExist(address))
                {
                    ListOfPostOffices.Add(new PostOffice(address.Town));
                }
            }
        }

        private void AddAddressesToPostOffice()
        {
            foreach (var address in _addresses)
            {
                PostOffice tempPostOffice = ReturnTownPostOffice(address.Town);

                if (tempPostOffice.PostAddresses.All(x => x != address))
                {
                    tempPostOffice.AddPostalAddress(address);
                }
                else
                {
                    tempPostOffice.DuplicateCount++;
                }
            }
        }

        private bool DoesPostOfficeExist(Address address)
        {
            return ListOfPostOffices.Any(x => x.Location == address.Town);
        }

        private PostOffice ReturnTownPostOffice(string town)
        {
            return ListOfPostOffices.Find(x => x.Location == town);
        }
    }
}
