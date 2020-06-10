using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people;
        public event EventHandler KeyPressed;


        public ContactsCenter(string peopleFile)
        {
            _people = new List<Person>();
            LoadList(peopleFile);
        }

        private void LoadList(string peopleFile)
        {
            if (string.IsNullOrEmpty(peopleFile)) throw new ArgumentNullException();
            if (!File.Exists(peopleFile)) throw new FileNotFoundException();
            using (StreamReader streamReader = new StreamReader(peopleFile))
            {
                if (string.IsNullOrEmpty(streamReader.ReadLine())) throw
                new ArgumentNullException("The file hasn't got any data.");

                while (!streamReader.EndOfStream)
                {

                    string[] personInfo = streamReader.ReadLine().Split(',');

                    GetPersonInfoAndAddPersonList(personInfo);
                }
            }
        }

        private void GetPersonInfoAndAddPersonList(string[] personInfo)
        {
            const int NAME_INDEX = 0;
            const int SURNAME_INDEX = 1;
            const int BIRTHDATE_INDEX = 2;
            const int GENDER_INDEX = 3;
            const int COUNTRY_INDEX = 4;
            const int EMAIL_INDEX = 5;
            const int STREET_ADDRESS_INDEX = 6;

            Person person = new Person(personInfo[NAME_INDEX], personInfo[SURNAME_INDEX], formatAndParseDateTime(personInfo[BIRTHDATE_INDEX]), personInfo[GENDER_INDEX], personInfo[COUNTRY_INDEX], personInfo[EMAIL_INDEX], personInfo[STREET_ADDRESS_INDEX]);

            _people.Add(person);
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            foreach (Person person in _people)
            {
                if (predicate.Invoke(person)) people.Add(person);
            }
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
