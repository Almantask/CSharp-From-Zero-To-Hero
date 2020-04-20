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
            _people = new List<Person>();
            if (string.IsNullOrWhiteSpace(peopleFile) || !File.Exists(peopleFile))
            {
                throw new FileNotFoundException($"The {nameof(peopleFile)} you gave does not exist.");
            }
            else
            {
                LoadPeople(peopleFile);
            }
        }

        private void LoadPeople(string peopleFile)
        {
            string[] peoples = File.ReadAllText(peopleFile).Split(Environment.NewLine);

            if (peoples.Length == 1)
            {
                throw new Exceptions.InvalidPeoplesFileException($"{peopleFile} was Empty");
            }

            foreach (string personLine in peoples)
            {
                if (Person.TryParse(personLine, out Person person))
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
            // predicate doesnt do anything untill called, just like delegate.
            // Assing what it must do first, for example with a lambda.
            //predicate = p => p.Age > 18;
            var people = new List<Person>();
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
