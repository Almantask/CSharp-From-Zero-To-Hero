using System;

namespace BootCamp.Chapter
{
    public static class Tests
    {
        public static bool IsValidBirthday(string birthday)
        {
            string[] split = birthday.Split('/');
            if (int.TryParse(split[0], out int month) &&
                int.TryParse(split[1], out int day) &&
                int.TryParse(split[2], out int year))
            {
                int[] splitDate =
                {
                month,
                day,
                year

                };
                if (splitDate[0] > 0 &&
                    splitDate[0] < 13 &&
                    splitDate[1] > 0 &&
                    splitDate[1] < 32 &&
                    splitDate[2] > 1900 &&
                    splitDate[2] < DateTime.Now.Year)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsValidGender(string gender)
        {
            if (gender == "Male" || gender == "Female")
            {
                return true;
            }
                
            return false;
        }
        public static bool IsValidEmail(string email)
        { 
            string[] splitEmailAt = email.Split('@');
            if (splitEmailAt.Length != 2)
            {
                return false;
            }
            foreach (string line in splitEmailAt)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    return false;
                }
            }

            string[] splitEmailDot = splitEmailAt[1].Split('.');
            if (splitEmailDot.Length != 2)
            {
                return false;
            }
            foreach (string line in splitEmailDot)
            {
                if (String.IsNullOrWhiteSpace(line))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
