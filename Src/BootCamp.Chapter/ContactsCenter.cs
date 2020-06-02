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
                bool firstIndexFlag = true;
                while (!streamReader.EndOfStream)
                {

                    string[] personInfo = streamReader.ReadLine().Split(',');

                    GetPersonInfoAndAddPersonList(personInfo);
                }
            }
        }

        private void GetPersonInfoAndAddPersonList(string[] personInfo)
        {
            Person person = new Person(personInfo[0], personInfo[1], formatAndParseDateTime(personInfo[2]), personInfo[3], personInfo[4], personInfo[5], personInfo[6]);

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
