using System;
using System.Collections.Generic;
using System.Reflection;

namespace BootCamp.Chapter
{
    class Demo
    {
        private const string path = @"C:\Users\Matthew\source\repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Input\MOCK_DATA.csv";
        private readonly ContactsCenter contactsParser = new ContactsCenter(path);
        public void DemoParserAndFilter()
        {
            Predicate<Person> filterA = PeoplePredicates.IsA;
            Predicate<Person> filterB = PeoplePredicates.IsB;
            Predicate<Person> filterC = PeoplePredicates.IsC;

            Predicate<Person>[] filters = {filterA, filterB, filterC};
            foreach(Predicate<Person> filter in filters)
            {
                List<Person> newList = new List<Person>();
                newList = contactsParser.Filter(filter);
                Console.WriteLine($"Number of People after appling Filter '{filter.GetMethodInfo().Name}': {newList.Count}");
            }
        }   
    }
}
