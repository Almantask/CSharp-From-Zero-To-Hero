using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public string SureName { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string StreetAdress { get; set; }
        public int Age { get => CalculateAge(); }

        public int CalculateAge()
        {
            int age = 0;
            age = DateTime.Now.Year - BirthDay.Year;
            if (DateTime.Now.DayOfYear < BirthDay.DayOfYear)
                age = age - 1;

            return age;
        }

        public static Person TryParse(string personString)
        {
            var splittedPerson = personString.Split(',');

            CultureInfo culture = new CultureInfo("en-US");
            var isValid = DateTime.TryParse(splittedPerson[2], culture, DateTimeStyles.None, out DateTime date);
            if (!isValid)
            {
                throw new ArgumentException("date is not valid");
            }

            isValid = Enum.TryParse(splittedPerson[3], true, out Gender gender);
            if (!isValid)
            {
                throw new ArgumentException("Gender can only be Male or Female");
            }

            var person = new Person();
            person.Name = splittedPerson[0];
            person.SureName = splittedPerson[1];
            person.BirthDay = date;
            person.Gender = gender;
            person.Country = splittedPerson[4];
            person.Email = splittedPerson[5];
            person.StreetAdress = splittedPerson[6];

            return person;
        }
    }
}
