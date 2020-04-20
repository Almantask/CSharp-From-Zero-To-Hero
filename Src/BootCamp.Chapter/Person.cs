using Microsoft.VisualBasic.CompilerServices;
using System;

namespace BootCamp.Chapter
{
    enum FieldsOrder
    {
        name,
        surName,
        birthday,
        gender,
        country,
        email,
        streetAddress
    }
    public class Person
    {
        private const int numberOfFields = 7;
        private const string header = "name,sureName,birthday,gender,country,email,streetAddress";


        public string FirstName { get; }
        public string SurName { get; }
        public DateTime Birthday { get; }
        public string Gender { get; }
        public string Country { get; }
        public string Email { get; }
        public string StreetAddress { get; }

        public int Age => GetAge();

        /// <summary>
        ///  create a person with the following properties.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="birthday"></param>
        /// <param name="gender"></param>
        /// <param name="country"></param>
        /// <param name="email"></param>
        /// <param name="streetAddress"></param>
        public Person(string name, string surName, string birthday, string gender, string country, string email, string streetAddress)
        {
            FirstName = name;
            SurName = surName;
            Birthday = ConvertStringToDateDime(birthday);
            Gender = gender;
            Country = country;
            Email = email;
            StreetAddress = streetAddress;
        }

        private int GetAge()
        {
            int age = DateTime.Now.Year - Birthday.Year;
            if (Birthday.Month > DateTime.Now.Month)
            {
                age--;
            }
            else if (Birthday.Month == DateTime.Now.Month && Birthday.Day > DateTime.Now.Day)
            {
                age--;
            }
            return age;
        }

        public static bool TryParse(string input, out Person person)
        {
            person = default;

            if (String.IsNullOrWhiteSpace(input) || input == header)
            {
                return false;
            }

            string[] splitInput = input.Split(',');
            if (splitInput.Length != numberOfFields || !IsInputValid(splitInput))
            {
                return false;
            }

            //"name,sureName,birthday,gender,country,email,streetAddress";
            person = new Person(
                splitInput[(int)FieldsOrder.name], 
                splitInput[(int)FieldsOrder.surName], 
                splitInput[(int)FieldsOrder.birthday], 
                splitInput[(int)FieldsOrder.gender], 
                splitInput[(int)FieldsOrder.country], 
                splitInput[(int)FieldsOrder.email], 
                splitInput[(int)FieldsOrder.streetAddress]);

            return true;
        }

        private DateTime ConvertStringToDateDime(string date)
        {
            const int dayIndex = 1;
            const int monthIndex = 0;
            const int yearIndex = 2;

            int day = int.Parse(date.Split('/')[dayIndex]);
            int month = int.Parse(date.Split('/')[monthIndex]);
            int year = int.Parse(date.Split('/')[yearIndex]);

            return new DateTime(year, month, day);
        }

        private static bool IsInputValid(string[] split)
        {
            foreach (string line in split)
            {
                if(String.IsNullOrWhiteSpace(line))
                {
                    return false;
                }
            }

            if (!Validator.IsValidBirthday(split[2]))
            {
                return false;
            }
            if (!Validator.IsValidGender(split[3]))
            {
                return false;
            }
            if (!Validator.IsValidEmail(split[5]))
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            return $"{FirstName} {SurName} Born on {Birthday} Is a {Gender} Lives in {Country} adres is {StreetAddress} to get in contact with use {Email}.";
        }
    }
}