using System;

namespace BootCamp.Chapter.Demo
{
    public class DemoCreateDB
    {
        public static void OnValidChoice(Predicate<Person> predicate)
        {
            var contacts = new ContactsCenter(@"Input/MOCK_DATA.csv");
            var peopleList = contacts.Filter(predicate);

            foreach (var person in peopleList)
            {
                Console.WriteLine($"[NAME]:{person.Name} {person.SureName} | [AGE]: {person.Age} | [COUNTRY]: {person.Country}");
            }
        }
    }
}