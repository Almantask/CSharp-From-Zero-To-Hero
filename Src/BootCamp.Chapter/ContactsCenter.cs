using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        public List<Person> peopleContactList { get; }

        public ContactsCenter(string peopleFile)
        {
            if(File.Exists(peopleFile) && new FileInfo(peopleFile).Length != 0)
            {
                peopleContactList = new List<Person>();
                ParsePeopleContactDetails(peopleFile);
            }
            else
            {
                throw new FileNotFoundException($"File at located at '{peopleFile}' either does not exist or is empty");
            } 
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            
            foreach(Person person in peopleContactList)
            {
                if (predicate(person))
                {
                    people.Add(person);
                }
            }
            return people;
        }

        private void ParsePeopleContactDetails(string path)
        {
            using (var reader = new StreamReader(File.OpenRead(path)))
            {
                int count = 0; // used to ignore the first line of the CSV file
                while (!reader.EndOfStream)
                {
                    if (count == 0)
                    {
                        reader.ReadLine();
                        count++;
                    }
                    else
                    {
                        string parsedInformation = reader?.ReadLine().ToString();
                        string[] contactDetails = parsedInformation.Split(",");
                        



                        // add functionality to catch whether part of the contact detail  is Null or Void and it should be replaced with a placeholder.
                        peopleContactList.Add(new Person(contactDetails[0], contactDetails[1], contactDetails[2], contactDetails[3], contactDetails[4], contactDetails[5], contactDetails[6], CalculateAge(contactDetails[2])));
                    }
                }
            }
        }

        private int CalculateAge(string dob)
        {
            string[] dobNum = dob.Split("/");
            int year = int.Parse(dobNum[2]);
            int month = int.Parse(dobNum[0]);
            int day = int.Parse(dobNum[1]);

            DateTime newDob = new DateTime(year, month, day);
            int dateInYears = new DateTime(DateTime.Now.Subtract(newDob).Ticks).Year - 1;
            return dateInYears;
        }
    }
}
