using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var demo = new Demo();
            demo.DemoStarted += onDemoStarted;
            demo.PredicateChosen += OnPredicateChosen;
            demo.DemoEnded += onDemoEnded;
            demo.ApplicationClosed += OnApplicationClosed;

            demo.Run();
        }

        private static void onDemoStarted(object sender, EventArgs args)
        {
            Console.WriteLine("the demo has started");
        }

        private static void onDemoEnded(object sender, EventArgs args)
        {
            Console.WriteLine("the demo has ended");
        }

        private static void OnApplicationClosed(object sender, EventArgs e)
        {
            Console.WriteLine("the application has closed");
        }

        public static void OnPredicateChosen(object sender, PredicateEventArgs e)
        {
            var contact = new ContactsCenter(@"Input/MOCK_DATA.csv");
            var persons = new List<Person>();

            // contains all people who are qualified by the predicate
            var qualifiedPersons = new List<Person>();
            var number = "1"; 
            switch (e.Choice)
            {
                case "1":
                    qualifiedPersons = contact.Filter(PeoplePredicates.IsA);
                    break;

                case "2":
                    qualifiedPersons = contact.Filter(PeoplePredicates.IsB);
                    break;

                case "3":
                    qualifiedPersons = contact.Filter(PeoplePredicates.IsC);
                    break;

                default:
                    Console.WriteLine("you make non valid choice");
                    break;
            }

            Console.WriteLine("The persons who are filterd out are");
            foreach (var person in qualifiedPersons)
            {
                Console.WriteLine($"{person.Name} {person.SureName}");
            }
        }

        
    }
}