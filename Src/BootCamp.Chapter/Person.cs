using Microsoft.VisualBasic.CompilerServices;
using System;

namespace BootCamp.Chapter
{
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

        public Person(string name, string surName, string birthday, string gender, string country, string email, string streetAddress)
        {
            FirstName = name;
            SurName = surName;
            Birthday = ConvertToDateDime(birthday);
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

            int age = year - Birthday.Year;
            if (Birthday.Month > month)
            {
                age--;
            }
            else if (Birthday.Month == month && Birthday.Day > day)
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

            person = new Person(splitInput[0], splitInput[1], splitInput[2], splitInput[3], splitInput[4], splitInput[5], splitInput[6]);

            return true;
        }

        private DateTime ConvertToDateDime(string date)
        {
            int day = int.Parse(date.Split('/')[1]);
            int month = int.Parse(date.Split('/')[0]);
            int year = int.Parse(date.Split('/')[2]);

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