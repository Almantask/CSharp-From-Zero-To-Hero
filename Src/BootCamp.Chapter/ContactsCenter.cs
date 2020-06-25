using BootCamp.Chapter.DataReader;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people = new List<Person>();

        public ContactsCenter(string peopleFile)
        {
            IExcelDataReader excelDataReader = new ExcelCsvReader(peopleFile);
            var peopleData = excelDataReader.GetData();

            if (peopleData.Length < 1) throw new ArgumentOutOfRangeException();

            foreach (var line in peopleData[1..])
            {
                if (Person.TryParse(line, out Person person))
                    _people.Add(person);
            }
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();

            foreach (var person in _people)
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
