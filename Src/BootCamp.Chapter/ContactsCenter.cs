using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people;

        public ContactsCenter(string peopleFile)
        {
            // load people
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            // ToDo: implement applying filter.
            return people;
        }
    }
}
