using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people;

        public ContactsCenter(string peopleFile)
        {
            if (!File.Exists(peopleFile))
            {
                throw new FileNotFoundException("File is made up");
            }

            var contents = File.ReadAllLines(peopleFile);

            if (contents.Length == 0)
            {
                throw new InvalidOperationException("File cannot be empty");
            }

            _people = new List<Person>(); 

            for (int i = 1; i < contents.Length; i++)
            {
                var isValid = Person.TryParse(contents[i], out Person person);

                if (isValid)
                {
                    _people.Add(person);
                }
            }
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            // skipped the first row because its a header.
            for (int i = 0; i < _people.Count - 1; i++)
            {
                var person = _people[i]; 
                if (predicate(_people[i]))
                {
                    people.Add(_people[i]);
                }
            }

            return people;
        }
    }
}