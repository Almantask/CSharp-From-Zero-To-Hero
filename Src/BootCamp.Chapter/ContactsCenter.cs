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
            // MY COMMENT  predicate doesnt do anything untill called, just like delegate.
            // Assing what it must do first, for example with a lambda.
            //predicate = p => p.Age > 18;
            var people = new List<Person>();
            // ToDo: implement applying filter.
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
