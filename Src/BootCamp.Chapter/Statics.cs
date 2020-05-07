using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace BootCamp.Chapter
{
    internal class Statics
    {
        internal static string FindPostOfficeWithMostErrors(List<Address> data)
        {
            var FoundOffices = new Dictionary<string, int>();

            foreach (var address in data)
            {
                if (FoundOffices.ContainsKey(address.PostalCode))
                {
                    continue;

                }

                var count = data.Count(x => x == address);

                FoundOffices.Add(address.PostalCode, count); 
            }

            return FoundOffices.OrderByDescending(x => x.Value).First().Key; 
        }

    }
}