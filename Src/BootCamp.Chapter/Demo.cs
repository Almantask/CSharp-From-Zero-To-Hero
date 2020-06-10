using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Demo
    {
        public static EventHandler Demo_Started;
        public static void Started(object? sender, EventArgs e)
        {

            ConsoleKey consoleKey = (ConsoleKey) sender;
            ContactsCenter contactsCenter = new ContactsCenter(@"Input/MOCK_DATA.csv");
            List<Person> filteredPeople = new List<Person>();

            switch (consoleKey)
            {
                case ConsoleKey.A:
                    filteredPeople = contactsCenter.Filter(PeoplePredicates.IsA);
                    break;

                case ConsoleKey.B:
                    filteredPeople = contactsCenter.Filter(PeoplePredicates.IsB);
                    break;

                case ConsoleKey.C:
                    filteredPeople = contactsCenter.Filter(PeoplePredicates.IsC);
                    break;
                case ConsoleKey.Escape:
                    Program.flag = false;
                    break;
                default:
                    Console.WriteLine("You select wrong selection.");
                    break;

            }

            foreach (var person in filteredPeople)
            {
                Console.WriteLine($"Name: {person.Name} - Surname: {person.Surname} - Age: {person.Age} - Country: {person.Country}");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("****************************************");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
