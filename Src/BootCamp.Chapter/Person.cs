using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        public string Name { get; }
        public string SureName { get; }
        public string Gender { get; }
        public string Country { get; }
        public string Email { get; }
        public string StreetAddress { get; }
        
        private DateTime _birthday;
        public int Age => GetAge();
        
        public Person(string name, string sureName, string birthday, string gender, string country, string email,
            string streetAddress)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            SureName = sureName ?? throw new ArgumentNullException(nameof(sureName));
            Gender = gender ?? throw new ArgumentNullException(nameof(gender));
            Country = country ?? throw new ArgumentNullException(nameof(country));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            StreetAddress = streetAddress ?? throw new ArgumentNullException(nameof(streetAddress));
            
            if (!DateTime.TryParse(birthday, CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None, 
                out var parsedBirthday))
            {
                throw new ArgumentOutOfRangeException(nameof(birthday), "Invalid date format.");
            }
            _birthday = parsedBirthday;
        }
        
        private int GetAge()
        {
            var timeNow = DateTime.Now;
            var age = (timeNow.Date - _birthday.Date).Days / 365;

            return age;
        }
    }
}