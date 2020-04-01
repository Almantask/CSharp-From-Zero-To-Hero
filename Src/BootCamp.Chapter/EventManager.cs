using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class EventManager
    {
        public static Events ManageEvents()
        {
            var events = new Events();
            events.DemoStarted += OnDemoStarted;
            events.DemoEnded += OnDemoEnded;
            events.ChoosePredicate += ChoosePredicates;
            events.ApplicationClosed += OnApplicationClosed;

            return events; 
        }

        protected static void OnDemoStarted(object sender, EventArgs e)
        {
            Console.WriteLine("The demo has started");
        }

        protected static void OnDemoEnded(object sender, EventArgs e)
        {
            Console.WriteLine("the demo has ended");
        }

        protected static void OnApplicationClosed(object sender, EventArgs e)
        {
            Console.WriteLine("the application has closed");
        }

        protected static void ChoosePredicates(object sender, EventArgs e)
        {
            var menuChoice = MenuPredicates();
            var contact = new ContactsCenter(@"Input/MOCK_DATA.csv");
            var persons = new List<Person>();

            var answer = new List<Person>();
            switch (menuChoice)
            {
                case "1":
                    answer = contact.Filter(PeoplePredicates.IsA);
                    break;
                case "2":
                    answer = contact.Filter(PeoplePredicates.IsB);
                    break;
                case "3":
                    answer = contact.Filter(PeoplePredicates.IsC);
                    break;
                default:
                    Console.WriteLine("you make non valid choice");
                    break;
            }

            Console.WriteLine("The persons who are filterd out are");
            foreach (var person in answer)
            {
                Console.WriteLine($"{person.Name} {person.SureName}");
            }
        }

        private static string MenuPredicates()
        {
            Console.WriteLine($"Choose on the following fiters you want to use. {Environment.NewLine}");
            Console.WriteLine("1) Persons older then 18 which do not live in the UK and which surname does not contain the character a ");
            Console.WriteLine("2) Persons who are younger then 18 and who surname does not contain the character a");
            Console.WriteLine("3) Persons who do no live in the Uk and where both the name and surnmae contains the character a");
            var choice = Console.ReadLine();
            return choice;


        }
    }

}
