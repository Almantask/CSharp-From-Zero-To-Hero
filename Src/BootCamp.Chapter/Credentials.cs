using System;
using System.Text;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public string Username;
        public string Password;

        public Credentials(string username, string password)
        {
            if (String.IsNullOrEmpty(username) & (String.IsNullOrEmpty(password)))
            {
                throw new ArgumentException(); 
            }

            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default(Credentials);
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }

            var parts = input.Split(",");

            if (parts.Length != 2)
            {
                return false;
            }


            var name = parts[0];
            var password = Encoding.Unicode.GetBytes(parts[1]);
            var encodedPassWord = Encoding.Unicode.GetString(password);

            credentials = new Credentials(name, encodedPassWord);

            return true;
        }

        public bool Equals(Credentials credentials2)
        {
            return this.Username == credentials2.Username & this.Password == credentials2.Password; 
        }
    }
}
