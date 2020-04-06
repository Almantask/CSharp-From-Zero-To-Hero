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

        public static bool TryParse(string input, out Person person)
        {
            var splittedPerson = input.Split(',');

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

            var person1 = new Person(); 
            person1.Name = splittedPerson[0];
            person1.SureName = splittedPerson[1];
            person1.BirthDay = date;
            person1.Gender = gender;
            person1.Country = splittedPerson[4];
            person1.Email = splittedPerson[5];
            person1.StreetAdress = splittedPerson[6];

            person = person1; 
            return true; 
        }
    }
}