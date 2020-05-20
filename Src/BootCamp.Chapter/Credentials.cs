using System;
using System.Data;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public readonly struct Credentials : IEquatable<Credentials>
    {
        public readonly string Username;
        public readonly string Password;
        private const string Delimiter = ",";

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

            if (String.IsNullOrWhiteSpace(input))
                return false;

            var values = input.Split(Delimiter);

            if (values.Length == 0 || values.Length == 1)
                return false;

            var isValid = !String.IsNullOrWhiteSpace(values[0]) || !String.IsNullOrWhiteSpace(values[1]);

            if (!isValid)
                return false;

            credentials = new Credentials(values[0], values[1]);
            return true;
        }

        public bool Equals(Credentials other)
        {
            return Username == other.Username && Password == other.Password;
        }

        public override string ToString()
        {
            return $"{Username}{Delimiter}{Password}";
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
