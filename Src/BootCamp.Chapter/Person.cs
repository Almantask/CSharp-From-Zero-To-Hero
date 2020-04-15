using Microsoft.VisualBasic.CompilerServices;
using System;

namespace BootCamp.Chapter
{
    public class Person
    {
        private const int numberOfFields = 7;

        public string FirstName { get; }
        public string SurName { get; }
        public string Birthday { get; }
        public string Gender { get; }
        public string Country { get; }
        public string Email { get; }
        public string StreetAddress { get; }

        public Person(string name, string surName, string birthday, string gender, string country, string email, string streetAddress)
        {
            FirstName = name;
            SurName = surName;
            Birthday = birthday;
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

            int birthDay = int.Parse(Birthday.Split('/')[1]);
            int birthMonth = int.Parse(Birthday.Split('/')[0]);
            int birthYear = int.Parse(Birthday.Split('/')[2]);

            int age = year - birthYear;
            if (birthMonth > month)
            {
                age--;
            }
            else if (birthMonth == month && birthDay > day)
            {
                age--;
            }
            return age;
        }

        public static bool TryParse(string input, out Person person)
        {
            person = default;

            if (String.IsNullOrWhiteSpace(input))
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

        private static bool IsInputValid(string[] split)
        {
            foreach (string line in split)
            {
                if(String.IsNullOrWhiteSpace(line))
                {
                    return false;
                }
            }

            if (!Tests.IsValidBirthday(split[2]))
            {
                return false;
            }
            if (!Tests.IsValidGender(split[3]))
            {
                return false;
            }
            if (!Tests.IsValidEmail(split[5]))
            {
                return false;
            }

            return true;
        }
    }
}