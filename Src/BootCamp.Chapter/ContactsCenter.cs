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
            _people = Person.ConvertFromFile(peopleFile);
		}

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
			List<Person> people = new List<Person>();
            //implement applying filter.
            foreach (Person person in _people)
            {
                if (predicate(person))
                {
                    people.Add(person);
                }
            }

            return people;
        }
    }
}
