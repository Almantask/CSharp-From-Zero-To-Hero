using System;

namespace BootCamp.Chapter
{
    public enum Gender
    {
        male,
        female
    }
    public class Person
    {
        // add missing properties

        private string name;
        public string Name
        {
            get { return this.name; }
        }

        private string surname;
        public string Surname
        {
            get { return this.surname; }
        }

        private DateTime birthday; //https://docs.microsoft.com/en-us/dotnet/standard/base-types/parsing-datetime
        public DateTime Birthday
        {
            get { return this.birthday; }
        }

        private Gender gender; //https://docs.microsoft.com/en-us/dotnet/api/system.enum.parse?view=net-6.0
        public Gender Gender
        {
            get { return this.gender; }
        }

        private string country;
        public string Country
        {
            get { return this.country; }
        }

        private string email;
        public string Email
        {
            get { return this.email; }
        }

        private string streetAddress;
        public string StreetAddress
        {
            get { return this.streetAddress; }
        }

        public Person(string name, string surname, DateTime birthday, string gender, string country, string email, string streetAddress)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.gender = (Gender)Enum.Parse(typeof(Gender), gender); //https://www.dotnetperls.com/enum-parse
            this.country = country;
            this.email = email;
            this.streetAddress = streetAddress;
        }



    }
}