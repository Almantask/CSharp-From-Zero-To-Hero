using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        // add missing properties: name,sureName,birthday,gender,country,email,streetAddress
        public string Name { get; }
        public string Surname { get; }
        public string Gender { get; }
        public string Country { get; }
        public string Email { get; }
        public string StreetAddress { get; }
        public int Age => GetAge();

        private DateTime _birthday;

        public Person(string name, string surname, string birthday, string gender, string country, string email, string streetAddress)
        {
            Name = name ?? throw new ArgumentNullException($"{nameof(name)} cannot be null.");
            Surname = surname ?? throw new ArgumentNullException($"{nameof(surname)} cannot be null.");
            Gender = gender ?? throw new ArgumentNullException($"{nameof(gender)} cannot be null.");
            Country = country ?? throw new ArgumentNullException($"{nameof(country)} cannot be null.");
            Email = email ?? throw new ArgumentNullException($"{nameof(email)} cannot be null.");
            StreetAddress = streetAddress ?? throw new ArgumentNullException($"{nameof(streetAddress)} cannot be null.");

            // ToDo: parse DateTime struct
            if (DateTime.TryParse(birthday, CultureInfo.GetCultureInfo("en-US"), DateTimeStyles.None, out DateTime parsedBirthday))
            {
                _birthday = parsedBirthday;
            }
            else
            {
                throw new ArgumentException($"{nameof(birthday)} has invalid format and cannot be parsed");
            }
        }

        private int GetAge()
        {
            var timeNow = DateTime.Now;
            var age = (timeNow.Date - _birthday.Date).Days / 365;

            return age;
        }

        public static bool TryParse(string input, out Person person)
        {
            person = default;

            if (string.IsNullOrWhiteSpace(input)) return false;

            var personalData = input.Split(',');

            var name = personalData[0];
            var surname = personalData[1];
            var birthday = personalData[2];
            var gender = personalData[3];
            var country = personalData[4];
            var email = personalData[5];
            var streetAddress = personalData[6];

            person = new Person(name, surname, birthday, gender, country, email, streetAddress);

            return true;
        }
    }
}