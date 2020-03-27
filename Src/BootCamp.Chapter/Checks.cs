using System;

namespace BootCamp.Chapter
{
    public static class Checks
    {
        public static bool IsNameValid(string name)
        {
            const string goodLeters = "abcdefghijklmnopqrstuvwxyz";

            if (name.Length < 3 || name.Length > 14)
            {
                return false;
            }
            foreach (char letter in name)
            {
                if (!goodLeters.Contains(Char.ToLower(letter)))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsPasswordValid(string password)
        {
            bool containLower = false;
            bool containUpper = false;
            bool containNumber = false;
            bool containSpecial = false;
            const string special = @"!@#$%^&*()-_=+/\|{}[]<>.?";

            if (password.Length < 8 || password.Length > 50)
            {
                return false;
            }

            foreach (char letter in password)
            {
                if (containLower && containUpper && containNumber && containSpecial)
                {
                    return true;
                }
                if (special.Contains(letter))
                {
                    containSpecial = true;
                }
                if (Char.IsDigit(letter))
                {
                    containNumber = true;
                }
                if (Char.IsLower(letter))
                {
                    containLower = true;
                }
                if (Char.IsUpper(letter))
                {
                    containUpper = true;
                }
            }
            return containLower && containUpper && containNumber && containSpecial;
        }
    }
}
