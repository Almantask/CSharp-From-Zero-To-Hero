using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people = new List<Person>();

        public ContactsCenter(string peopleFile)
        {
            // load people
            StreamReader reader = new StreamReader(peopleFile);

            using(reader)
            {
                int lineNumber = 0;
                // Read first line from the text file
                string line = reader.ReadLine();
                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    //Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                    bool ok = string.IsNullOrEmpty(line);

                    if (!ok)
                    {
                        string[] personData = line.Split(",");
                        _people.Add(new Person(personData[0], personData[1], personData[2], personData[3], personData[4], personData[5], personData[6]));
                    }
                }
            }
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
    }
}
