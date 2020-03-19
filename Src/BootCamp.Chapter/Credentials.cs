using System;

namespace BootCamp.Chapter
{
    public readonly struct Credentials : IEquatable<Credentials>
    {
        public readonly string Name;
        public readonly string Password;

        public Credentials(string name, string password)
        {
            Name = name;
            Password = password;
        }

        public override string ToString()
        {
            return $"{Name},{Password}";
        }

        public bool Equals(Credentials other)
        {
            return Name == other.Name && Password == other.Password;
        }

        public static bool operator ==(Credentials left, Credentials right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Credentials left, Credentials right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Password);
        }

        public override bool Equals(object obj)
        {
            return obj is Credentials user && Name == user.Name && Password == user.Password;
        }
    }
}