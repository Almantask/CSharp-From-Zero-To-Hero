using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    class Program
    {
        private static EventHandler _keyPressed;
        static bool flag = true;
        static void Main(string[] args)
        {
            
            while (flag)
            {
                Console.WriteLine("Hello World!");
                ContactsCenter contactsCenter = new ContactsCenter(@"Input/MOCK_DATA.csv");
                _keyPressed += KeyPressed;
                _keyPressed?.Invoke(Selection(), EventArgs.Empty);
            }
            
        }
        private static void KeyPressed(object? sender, EventArgs e)
        {
            ConsoleKey consoleKey = (ConsoleKey)sender;
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
                    flag = false;
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

        private static ConsoleKey Selection()
        {
            Console.WriteLine("Select:");
            Console.WriteLine("a) over 18, who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("b) under 18,  who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("c) who do not live in UK, whose surname and name does not contain letter 'a'.");
            Console.WriteLine("ESC) for exit");
            Console.WriteLine(Environment.NewLine);
            return Console.ReadKey(true).Key;
        }
    }
}
