using System;
using System.ComponentModel.DataAnnotations;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public readonly struct Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) throw new ArgumentException("user name and password not be empty.");

            Username = username;
            Password = password;
        }

        //Credentials.TryParse(credentialsString, out var credentials);

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            if (string.IsNullOrEmpty(input))
            {
                credentials = default;
                return false;
            }

            var separatedValues = input.Split(",");
            if (separatedValues.Length < 2)
            {
                credentials = default;
                return false;
            }

            if (string.IsNullOrEmpty(separatedValues[0]) || string.IsNullOrEmpty(separatedValues[1]))
            {
                credentials = default;
                return false;
            }
            credentials = new Credentials(separatedValues[0], separatedValues[1]);
            return true;
        }

        public static bool credentialsNotNull(Credentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.Username) && string.IsNullOrEmpty(credentials.Password)) return false;

            return true;
        }
    }
}
