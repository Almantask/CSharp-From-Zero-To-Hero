using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsCenter
    {
        public List<Person> People { get; } = new List<Person>();

        public ContactsCenter(string peopleFile)
        {
            if (!File.Exists(peopleFile)) throw new FileNotFoundException();
            var fileContent = File.ReadAllLines(peopleFile);
            if (fileContent.Length < 1) throw new ArgumentOutOfRangeException();

            CreatePeopleDatabase(fileContent[1..]);
        }

        private void CreatePeopleDatabase(string[] fileContent)
        {
            foreach (var person in fileContent)
            {
                var personInfo= person.Split(",");

                if (person.Contains('\"')) personInfo = SplitQuotaCase(personInfo);
                if (personInfo.Length != 7) throw new ArgumentOutOfRangeException(nameof(personInfo));
                
                var name = personInfo[0];
                var sureName = personInfo[1];
                var birthday = personInfo[2];
                var gender = personInfo[3];
                var country = personInfo[4];
                var email = personInfo[5];
                var streetAddress = personInfo[6];
                
                People.Add(new Person(name, sureName, birthday, gender, country, email, streetAddress));
            }
        }

        /// <summary>
        /// Gets people by filter predicate.
        /// </summary>
        /// <returns></returns>
        public List<Person> Filter(Predicate<Person> predicate)
        {
            var people = new List<Person>();
            foreach (var person in People)
            {
                if (predicate(person))
                {
                    people.Add(person);
                }
            }
            
            return people;
        }
        
        private string[] SplitQuotaCase(string[] personInfo)
        {
            var updatedPersonInfo = new List<string>();
            
            var hasFoundQuota = false;
            var quotaLine = new StringBuilder();
            
            foreach (var info in personInfo)
            {
                if (info.Contains('\"'))
                {
                    if (!hasFoundQuota)
                    {
                        quotaLine.Append($"{info[1..]},");
                        hasFoundQuota = true;
                    }
                    else
                    {
                        quotaLine.Append(info[..^1]);
                        updatedPersonInfo.Add(quotaLine.ToString());
                        quotaLine = new StringBuilder();
                        hasFoundQuota = false;
                    }
                }
                else if (hasFoundQuota)
                {
                    quotaLine.Append($"{info},");
                }
                else
                {
                    updatedPersonInfo.Add(info);
                } 
            }

            return updatedPersonInfo.ToArray();
        }
    }
}
