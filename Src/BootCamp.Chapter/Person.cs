using System;
using System.Globalization;

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

        private int age;
        public int Age
        {
            get { return age; }
        }

        public Person(string name, string surname, string birthday, string gender, string country, string email, string streetAddress)
        {
            this.name = name;
            this.surname = surname;
            CultureInfo culture = new CultureInfo("en-US");
            DateTime tempDate = Convert.ToDateTime(birthday, culture);
            this.birthday = tempDate;
            this.gender = (Gender)Enum.Parse(typeof(Gender), gender, true); //https://www.dotnetperls.com/enum-parse
            this.country = country;
            this.email = email;
            this.streetAddress = streetAddress;
            this.age = CalculateAge(tempDate);
        }

        public int CalculateAge(DateTime birth)
        {
            var now = DateTime.Now;
            int age = now.Year - birth.Year;
            if (birth > now.AddYears(-age))
                age--;

            return age;
        }

        public override string ToString()
        {
            return String.Format($"{Name} {Surname}");
        }
    }
}