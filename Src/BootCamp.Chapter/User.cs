using System;

namespace BootCamp.Chapter
{
    public readonly struct User : IEquatable<User>
    {
        public readonly string Name;
        public readonly string Password;

        public User(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public bool Equals(User user)
        {
            return Name == user.Name && Password == user.Password;
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

        public override bool Equals(object obj)
        {
            return obj is User user && Name == user.Name && Password == user.Password;
        }
    }
}