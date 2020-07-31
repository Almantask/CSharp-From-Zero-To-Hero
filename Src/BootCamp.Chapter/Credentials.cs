using System;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("You must provide username");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("You must provide password");
            }
            Username = username;
            var encodedPassword = new EncodedPassword(password);
            Password = encodedPassword.PasswordAfterEncoding;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            if (string.IsNullOrEmpty(input)) return false;

            var CredentialsParts = input.Split(",");
            if (CredentialsParts.Length != 2) return false;

            if (string.IsNullOrEmpty(CredentialsParts[0]) || string.IsNullOrEmpty(CredentialsParts[1])) return false;

            credentials = new Credentials(CredentialsParts[0], CredentialsParts[1]);
            return true;
        }
        public readonly struct EncodedPassword
        {
            public readonly string PasswordAfterEncoding { get; }
            public EncodedPassword(string inputPassword)
            {
                var unicode = new UnicodeEncoding();
                byte[] passwordInByteArray = unicode.GetBytes(inputPassword);
                PasswordAfterEncoding = string.Join(" ", passwordInByteArray);
            }
        }

        public string GetCredentials()
        {
            Console.WriteLine($"string password: {Password}");
            return $"{Username},{Password}";
        }

        public bool Equals(Credentials credentialsToCompare)
        {
            return (Username.Equals(credentialsToCompare.Username) && Password.Equals(credentialsToCompare.Password));
        }
    }
}
