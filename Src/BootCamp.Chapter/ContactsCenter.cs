using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly string _peopleFile;

        public ContactsCenter(string peopleFile)
        {
            if (!File.Exists(peopleFile))
            {
                throw new FileNotFoundException("File is made up");
            }

            _peopleFile = File.ReadAllText(peopleFile);

            if (String.IsNullOrWhiteSpace(_peopleFile))
            {
                throw new InvalidOperationException("File cannot be empty");
            }
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            var splittedList = _peopleFile.Split(Environment.NewLine);
            // skipped the first row because its a header.
            for (int i = 1; i < splittedList.Length - 1; i++)
            {
                var isValid = Person.TryParse(splittedList[i], out Person person); 
                if (predicate(person))
                {
                    people.Add(person);
                }
            }

            return people;
        }

    }
}