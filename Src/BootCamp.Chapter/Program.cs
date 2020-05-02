using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var contacts = new ContactsCenter(@"Input/MOCK_DATA.csv");

            var hue = contacts.Filter(PeoplePredicates.IsA);

            Console.Read();

        }
    }
}
