using System;

namespace BootCamp.Chapter
{
    public class Person
    {
        // add missing properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public int Age { get; set; }

        public Person(string name, string surname, DateTime birthDate, string gender, string country, string email, string streetAddress)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
            Gender = gender;
            Country = country;
            Email = email;
            StreetAddress = streetAddress;
            Age = DateTime.Now.Subtract(BirthDate).Days / 365;
        }
    }
}