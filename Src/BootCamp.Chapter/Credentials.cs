using System;
using System.Diagnostics.CodeAnalysis;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public readonly struct Credentials : IEquatable<Credentials>
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            if (String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
                throw new ArgumentException($"{nameof(username)} or {nameof(password)} cannot be null or empty.");

            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            return false;
        }

        public bool Equals(Credentials other)
        {
            return Username == other.Username && Password == other.Password;
        }

        public override string ToString()
        {
            return $"{Username}:{Password}";
        }

        public static bool operator ==(Credentials leftExpression, Credentials rightExpression)
        {
            return leftExpression.Equals(rightExpression);
        }

        public static bool operator !=(Credentials leftExpression, Credentials rightExpression)
        {
            return !(leftExpression == rightExpression);
        }
    }
}
