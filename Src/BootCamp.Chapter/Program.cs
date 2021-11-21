using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            Console.ReadKey();
        }
    }
}
