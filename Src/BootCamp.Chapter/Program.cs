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
            demo.ChoosePredicate += ChoosePredicates;
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

        protected static void ChoosePredicates(object sender, EventArgs e)
        {
            var menuChoice = DisplayPredicateChoises();
            var contact = new ContactsCenter(@"Input/MOCK_DATA.csv");
            var persons = new List<Person>();

            // contains all people who are qualified by the predicate
            var qualifiedPersons = new List<Person>();
            switch (menuChoice)
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

        private static string DisplayPredicateChoises()
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