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
        public event EventHandler KeyPressed;


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
