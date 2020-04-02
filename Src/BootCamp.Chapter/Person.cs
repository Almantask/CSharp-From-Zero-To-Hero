using System;

namespace BootCamp.Chapter
{
    public enum GenderEnum
    {
        Male,
        Female,
        Other
    }

    public class Person
    {
        private const string separator = ",";
        private const int fieldsNumber = 7;
        private const string fileHeader = "name,sureName,birthday,gender,country,email,streetAddress";

        public string Name { get; set; }

        public string SureName { get; set; }

        public DateTime Birthdate { get; set; }

        public GenderEnum Gender { get; set; }

        public string Country { get; set; }

        public string Email { get; set; }

        public string StreetAdress { get; set; }

        public int Age => DateTime.Now.Year - Birthdate.Year;

        public static bool TryParse(string input, out Person person)
        {
            person = default;

            if (!Utils.IsValid(input))
            {
                return false;
            }

            var fields = input.Split(separator);

            if (!(fields.Length == fieldsNumber && AreValid(fields)))
            {
                return false;
            }

            person = new Person()
            {
                Name = fields[0],
                SureName = fields[1],
                Birthdate = DateTime.Parse(fields[2]),
                Gender = ParseGender(fields[3]),
                Country = fields[4],
                StreetAdress = fields[5],
                Email = fields[6]
            };

            return true;
        }

        private static bool AreValid(string[] input)
        {
            if (input is null)
            {
                return false;
            }

            if (string.Join(separator, input) == fileHeader)
            {
                return false;
            }

            foreach (var field in input)
            {
                if (!Utils.IsValid(field))
                {
                    return false;
                }
            }

            return true;
        }

        private static GenderEnum ParseGender(string input)
        {
            if (!Utils.IsValid(input))
            {
                throw new ArgumentException($"{nameof(input)} can not be null or empty");
            }

            if (input == "Male")
            {
                return GenderEnum.Male;
            }
            else if (input == "Female")
            {
                return GenderEnum.Female;
            }
            else if (input == "Other")
            {
                return GenderEnum.Other;
            }
            else
            {
                throw new ArgumentException("invalid gender input");
            }
        }
    }
}