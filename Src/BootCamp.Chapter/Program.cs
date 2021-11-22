using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
                3) Demo this using events-based user input.  
                Display controls, handle input presses for for the following events:  
                a) DemoStarted  
                b) Example selected (from 2) a, b, c)  
                c) DemoEnded  
                d) Application closed
             * 
             */

            Console.WriteLine("Choose an option:");
            Console.WriteLine("a) over 18, who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("b) under 18,  who do not live in UK, whose surename does not contain letter 'a'.");
            Console.WriteLine("c) who do not live in UK, whose surename and name does not contain letter 'a'.");
            Console.WriteLine("Type in a, b or c");
            string userInput = Console.ReadLine();
            bool isRunning = false;

            ContactsCenter contacts = new ContactsCenter(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");

            do
            {
                switch (userInput)
                {
                    case "a":
                        Predicate<Person> predicateIsA = new Predicate<Person>(PeoplePredicates.IsA);
                        List<Person> aList = contacts.Filter(predicateIsA);
                        foreach(Person p in aList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }
                        isRunning = false;
                        break;

                    case "b":
                        Predicate<Person> predicateIsB = new Predicate<Person>(PeoplePredicates.IsB);
                        List<Person> bList = contacts.Filter(predicateIsB);
                        foreach (Person p in bList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }
                        isRunning = false;
                        break;

                    case "c":
                        Predicate<Person> predicateIsC = new Predicate<Person>(PeoplePredicates.IsC);
                        List<Person> cList = contacts.Filter(predicateIsC);
                        foreach (Person p in cList)
                        {
                            Console.WriteLine($"{p.Name} {p.Surname} {p.Age} {p.Country}");
                        }
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Wrong input, please choose between a, b or c");
                        userInput = Console.ReadLine();
                        isRunning = true;
                        break;
                }

            } while (isRunning);
         
            Console.ReadKey();
        }

        public static void MyTests()
        {

            Person p = new Person("Pete", "R", "12/18/1990", "male", "Poland", "mail@mail.com", "some address");

            if(p.Gender == Gender.male)
            {
                Console.WriteLine($"{p.Name} is male");
            }

            ContactsCenter contacts = new ContactsCenter(@"C:\Users\piotr\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv");

            Predicate<Person> predicateIsA = new Predicate<Person>(PeoplePredicates.IsA);
            List<Person> aList = contacts.Filter(predicateIsA);

            Predicate<Person> predicateIsB = new Predicate<Person>(PeoplePredicates.IsB);
            List<Person> bList = contacts.Filter(predicateIsB);

            Predicate<Person> predicateIsC = new Predicate<Person>(PeoplePredicates.IsC);
            List<Person> cList = contacts.Filter(predicateIsC);

            // a, b, c zwraca wartosc, zaimplementowac to nowym switch i dodac events
        }
    }
}
