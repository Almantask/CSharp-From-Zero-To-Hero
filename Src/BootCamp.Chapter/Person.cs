using System;

namespace BootCamp.Chapter
{
    public class Person
    {
        //TODO: add missing properties
        // name,sureName,birthday,gender,country,email,streetAddress
        // Chrisy,Frise,4/24/1946,Male,Philippines,cfrise0@europa.eu,62895 Troy Parkway
        public string FirstName { get; }
        public string SurName { get; }
        public string Birthday { get; }
        public string Gender { get; }
        public string Country { get; }
        public string Email { get; }
        public string StreetAddress { get; }

        public Person(string name, string surName, string birthday, string gender, string country, string email, string streetAddress)
        {
            FirstName = name;
            SurName = surName;
            Birthday = birthday;
            Gender = gender;
            Country = country;
            Email = email;
            StreetAddress = streetAddress;
        }

        public int GetAge()
        {
            string now = DateTime.Now.ToString().Split(' ')[0];
            int day = int.Parse(now.Split('/')[0]);
            int month = int.Parse(now.Split('/')[1]);
            int year = int.Parse(now.Split('/')[2]);

            int birthDay = int.Parse(Birthday.Split('/')[1]);
            int birthMonth = int.Parse(Birthday.Split('/')[0]);
            int birthYear = int.Parse(Birthday.Split('/')[2]);

            int age = year - birthYear;
            if (birthMonth > month)
            {
                age--;
            }
            else if (birthMonth == month && birthDay > day)
            {
                age--;
            }
            return age;
        }

    }
}