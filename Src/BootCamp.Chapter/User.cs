using System;
using System.Text;

namespace BootCamp.Chapter
{
    public readonly struct User
    {
        public readonly string Name;
        public readonly string Password;

        public User(string name, string password)
        {
            Name = name;
            Password = Encode(password);
        }

        public static bool TryParse(string input, out User user)
        {
            user = default;

            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var parts = input.Split(",");
            var isValid = parts.Length == 2 || parts[0].Length > 0 || parts[1].Length > 0;
            if (!isValid)
            {
                return false;
            }

            user = new User(parts[0], Decode(parts[1]));
            return true;
        }

        private static string Encode(string password)
        {
            return password;
        }

        private static string Decode(string password)
        {
            return password;
        }

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   Name == user.Name &&
                   Password == user.Password;
        }

        public static bool operator ==(User left, User right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(User left, User right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Password);
        }
    }
}