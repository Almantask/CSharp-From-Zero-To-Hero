using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people = new List<Person>();

        public ContactsCenter(string peopleFile)
        {
            string[] people;

            try
            {
                people = File.ReadAllLines(peopleFile);
            }
            catch
            {
                throw new FileNotFoundException();
            }

            foreach (var line in people)
            {
                _people.Add(StringToPerson(line));
            }

            // Remove header text.
            _people.RemoveAt(0);
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            return _people.Where(x => predicate(x)).ToList();
        }

        private static Person StringToPerson(string line)
        {
            var personData = line.Split(',');

            Person person = new Person();

            person.Name = personData[0];
            person.SureName = personData[1];
            DateTime.TryParse(personData[2], out DateTime birthday);
            person.Birthday = birthday;
            person.Gender = personData[3] == "Male" ? Enums.Gender.Male : Enums.Gender.Female;
            person.Country = personData[4];
            person.Email = personData[5];
            person.StreetAdress = personData[6];

            return person;
        }
    }
}
