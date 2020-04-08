using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people = new List<Person>();

        public ContactsCenter(string peopleFile)
        {
            if (!File.Exists(peopleFile))
            {
                throw new FileNotFoundException($"{peopleFile} was not found!");
            }

            string line;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(peopleFile);
                if (reader.EndOfStream)
                {
                    throw new ContactsFileIsEmptyException($"{peopleFile} is empty");
                }

                while ((line = reader.ReadLine()) != null)
                {
                    if (Person.TryParse(line, out Person person))
                    {
                        _people.Add(person);
                    }
                }
            }
            finally
            {
                reader?.Close();
            }
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            return _people.FindAll(predicate);
        }
    }
}