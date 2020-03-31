using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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
                throw new Exception(); 
            }
         
        }

       
        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            var splittedList = _peopleFile.Split($"{Environment.NewLine}");
            for (int i = 1; i < splittedList.Length; i++)
            {
                var person = ConvertStringToPerson(splittedList[i]);
                if (predicate(person))
                {
                    people.Add(person);
                }

            }
                   
            return people;
        }

        private Person ConvertStringToPerson(string personString)
        {
            var splittedPerson = personString.Split(',');
            var person = new Person();
            person.Name = splittedPerson[0];
            person.SureName = splittedPerson[1];
            person.BirthDay = splittedPerson[2];
            person.Gender = splittedPerson[3];
            person.Country = splittedPerson[4];
            person.Email = splittedPerson[5];
            person.StreetAdress = splittedPerson[6];

            return person; 

        }
    }
}
