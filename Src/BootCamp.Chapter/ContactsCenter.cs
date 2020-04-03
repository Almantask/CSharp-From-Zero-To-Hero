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
                var person = TryParse(splittedList[i]);
                if (predicate(person))
                {
                    people.Add(person);
                }
            }

            return people;
        }

        public Person TryParse(string personString)
        {

            if (String.IsNullOrEmpty(personString))
            {
                throw new ArgumentException("String cannot be empty"); 
            }

            var person = new Person(); 
            CultureInfo culture = new CultureInfo("en-US");
            var splittedPerson = personString.Split(',');
            
            if (String.IsNullOrEmpty(splittedPerson[0]))
            {
                throw new ArgumentException("name cannot be empty"); 
            }

            if (String.IsNullOrEmpty(splittedPerson[1]))
            {
                throw new ArgumentException("surename cannot be empty");
            }

            var isValid = DateTime.TryParse(splittedPerson[2], culture, DateTimeStyles.None, out DateTime date); 
            if (!isValid)
            {
                throw new ArgumentException("date is not valid"); 
            }

            isValid = Enum.TryParse(splittedPerson[3], true, out Gender gender);

            if (!isValid)
            {
                throw new ArgumentException("Gender can only be Male or Female");
            }

            if (String.IsNullOrEmpty(splittedPerson[4]))
            {
                throw new ArgumentException("country cannot be empty");
            }

            if (String.IsNullOrEmpty(splittedPerson[5]))
            {
                throw new ArgumentException("email cannot be empty");
            }

            if (String.IsNullOrEmpty(splittedPerson[6]))
            {
                throw new ArgumentException("street adress cannot be empty");
            }


            person.Name = splittedPerson[0];
            person.SureName = splittedPerson[1];
            person.BirthDay = date;
            person.Gender = gender; 
            person.Country = splittedPerson[4];
            person.Email = splittedPerson[5];
            person.StreetAdress = splittedPerson[6];
            
            return person; 
        }

       

    }
}