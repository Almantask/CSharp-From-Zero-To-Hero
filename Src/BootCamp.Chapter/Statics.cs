using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class Statics
    {
        internal static void FindPostOfficeWithMostErrors(List<Address> data)
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

            Console.WriteLine($"PostOffice with the most errors is: {FoundOffices.OrderByDescending(x => x.Value).First().Key}");
        }
    }
}