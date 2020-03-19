using System;
using System.Text;

namespace BootCamp.Chapter
{
    internal class CredentialsParsing
    {
        public struct Credentials
        {
            public Credentials(string name, string password)
            {
                Name = name;
                Password = password;
            }

            public string Name { get; set; }
            public string Password { get; set; }
        }

        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default(Credentials); 
            if (String.IsNullOrEmpty(input))
            {
                return false;
            }

            var parts = input.Split(" ");

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
    }
}