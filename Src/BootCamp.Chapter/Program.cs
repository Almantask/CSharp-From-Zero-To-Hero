using System;
using System.Collections.Generic;
using BootCamp.Chapter;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv";
            ContactsCenter contactsParser = new ContactsCenter(path);
            List<Person> parsedPeople = contactsParser.peopleContactList;

            foreach(Person person in parsedPeople)
            {
                person.TestContactDetailsDisplayer();
            }
        }
    }
}
