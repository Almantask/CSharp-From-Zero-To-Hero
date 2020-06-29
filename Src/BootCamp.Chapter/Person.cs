using System;
using System.Globalization;

namespace BootCamp.Chapter
{
    public class Person
    {
        private const int FirstNameColumn = 0;
        private const int SurnameColumn = 1;
        private const int BirthdayColumn = 2;
        private const int GenderColumn = 3;
        private const int CountryColumn = 4;
        private const int EmailColumn = 5;
        private const int StreetAddressColumn = 6;

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

            var name = personalData[FirstNameColumn];
            var surname = personalData[SurnameColumn];
            var birthday = personalData[BirthdayColumn];
            var gender = personalData[GenderColumn];
            var country = personalData[CountryColumn];
            var email = personalData[EmailColumn];
            var streetAddress = personalData[StreetAddressColumn];

            person = new Person(name, surname, birthday, gender, country, email, streetAddress);

            return true;
        }
    }
}