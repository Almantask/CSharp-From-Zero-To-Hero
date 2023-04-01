using System;
using System.Collections.Generic;
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
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username and/or password cannot be empty.");
            }
            
            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            if (!input.Contains(","))
                return false;
            
            var creds = input.Split(",");
            if (creds.Length < 2)
                return false;

            var password = creds[1];
            if (creds[1].Contains(" "))
            {
                var passwordTextSplit = creds[1].Split(" ");

                byte[] passwordBytes = new byte[passwordTextSplit.Length];

                for (int i = 0; i < passwordTextSplit.Length; i++)
                {
                    byte passwordByte = Convert.ToByte(passwordTextSplit[i]);
                    passwordBytes[i] = passwordByte;
                }

                password = Encoding.Unicode.GetString(passwordBytes);
            }

            credentials = new Credentials(creds[0], password);
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj is Credentials == false)
            {
                return false;
            }

            return ((Credentials) obj).Username == Username && ((Credentials) obj).Password == Password;
        }
        
    }
}
