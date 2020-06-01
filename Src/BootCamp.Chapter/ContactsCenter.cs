using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people;

        public ContactsCenter(string peopleFile)
        {
            _people = new List<Person>();
            LoadList(peopleFile);
        }

        private void LoadList(string peopleFile)
        {
            if (string.IsNullOrEmpty(peopleFile)) throw new ArgumentNullException();
            using (StreamReader streamReader = new StreamReader(peopleFile))
            {
                bool firstIndexFlag = true;
                while (!streamReader.EndOfStream)
                {
                    if (firstIndexFlag)
                    {
                        //we want to skip first row cause it's header.
                        //This looks weird but I couldn't find diferent way to do it.
                        streamReader.ReadLine();
                        firstIndexFlag = false;
                        continue;
                    }

                    string[] personInfo = streamReader.ReadLine().Split(',');

                    GetPersonInfoAndAddPersonList(personInfo);
                }
            }
        }

        private void GetPersonInfoAndAddPersonList(string[] personInfo)
        {
            Person person = new Person();

            person.Name = personInfo[0];
            person.Surname = personInfo[1];
            person.BirthDate = formatAndParseDateTime(personInfo[2]);
            person.Gender = personInfo[3];
            person.Country = personInfo[4];
            person.Email = personInfo[5];
            person.StreetAddress = personInfo[6];

            _people.Add(person);
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            // ToDo: implement applying filter.
            return people;
        }

        public DateTime formatAndParseDateTime(string readedDateTime)
        {
            string[] dateTimeValues = readedDateTime.Split('/');
            DateTime dateTime = new DateTime(int.Parse(dateTimeValues[2]), int.Parse(dateTimeValues[0]),
                int.Parse(dateTimeValues[1]));
            return dateTime;
        }
    }
}
