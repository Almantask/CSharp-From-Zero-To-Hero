using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Filters
    {
        private const string path = @"C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv";
        private readonly ContactsCenter contactsParser = new ContactsCenter(path);

        public void FilterA()
        {
            Predicate<Person> filterA = PeoplePredicates.IsA;


            List<Person> newList = new List<Person>();
            newList = contactsParser.Filter(filterA);
            Console.WriteLine($"Number of People after appling Filter A: {newList.Count}");

        }

        public void FilterB()
        {
            Predicate<Person> filterB = PeoplePredicates.IsB;

            List<Person> newList = new List<Person>();
            newList = contactsParser.Filter(filterB);
            Console.WriteLine($"Number of People after appling Filter B: {newList.Count}");
            
        }

        public void FilterC()
        {

            Predicate<Person> filterC = PeoplePredicates.IsC;

            List<Person> newList = new List<Person>();
            newList = contactsParser.Filter(filterC);
            Console.WriteLine($"Number of People after appling Filter C: {newList.Count}");
            
        }
    }
}
