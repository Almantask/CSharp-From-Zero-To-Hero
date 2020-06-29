using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Demo
{
    public static class ContactsCentreInitializer
    {
        public static void Initialize(Predicate<Person> predicate)
        {
            var contacts = new ContactsCenter(@"Input/MOCK_DATA.csv");
            var peopleList = contacts.Filter(predicate);

            foreach (var person in peopleList)
            {
                Console.WriteLine($"[Name]:{person.Name} {person.Surname} | [Age]: {person.Age} | [Country]: {person.Country}");
            }
        }
    }
}
