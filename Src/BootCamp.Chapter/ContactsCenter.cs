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
            try
            {
                _people = File.ReadAllLines(peopleFile).Select(s => StringToPerson(s)).ToList();
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException($"File MOCK_DATA.csv was not found. Details: {ex}");
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new FileNotFoundException($"Directory with the file MOCK_DATA.csv was not found. Details: {ex}");
            }

            // Remove header text.
            if (_people.Count != 0)
            {
                _people.RemoveAt(0);
            }
            else
            {
                throw new Exception("File was empty.");
            }
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
