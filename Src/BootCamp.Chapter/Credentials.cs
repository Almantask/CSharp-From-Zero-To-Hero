using System;
using System.Text;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public string Username;
        public string Password;

        public string ToFile { get { return $"{Username},{Password}{Environment.NewLine}"; } }

        public Credentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException();
            }
            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            string[] parts = input.Split(",", 2);
            if (parts.Length != 2)
            {
                return false;
            }

            string username = parts[0];
            string password = parts[1];

            credentials = new Credentials(username, password);
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Credentials)
            {
                Credentials other = obj as Credentials;
                return Username == other.Username && Password == other.Password;
            }
            return false;
        }
    }
}
