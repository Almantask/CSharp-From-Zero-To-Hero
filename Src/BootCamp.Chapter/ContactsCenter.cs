using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        private readonly List<Person> _people = new List<Person>();
        public List<Person> People
        {
            get { return _people; }
        }

        public ContactsCenter(string peopleFile)
        {
            // load people
            try
            {
                StreamReader reader = new StreamReader(peopleFile);

                using (reader)
                {
                    int lineNumber = 0;
                    // Read first line from the text file
                    string line = reader.ReadLine();

                    // Throw an exception because of empty file
                    if (line == null) throw new Exception();

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
            catch(DirectoryNotFoundException ex)
            {
                throw new FileNotFoundException();
            }
            catch(FileNotFoundException ex)
            {
                throw new FileNotFoundException();
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

            ///bool containA = predicate.Surname.Contains('a');
            //if (!containA)
            {
                var a = predicate = (person) => person.Age > 18 && person.Country != "UK";
                people.Add(predicate);
            }
            
            return people;
        }
    }
}
