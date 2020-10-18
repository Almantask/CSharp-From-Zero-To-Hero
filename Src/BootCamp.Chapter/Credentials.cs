using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public struct Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException();
            }

            Username = username;
            Password = password;
        }

        public static bool TryParse(string input, out Credentials credentials)
        {
            List<string> nameAndPassword = input.Split(",").ToList();
            
            try
            {
                credentials = new Credentials(nameAndPassword[0], nameAndPassword[1]);
                return true;
            }
            catch (System.Exception)
            {
                credentials = default;
                return false;
            }
        }

        public string ConvertCredentialsToString()
        {
            return $"{Username},{Password}";
        }
    }
}
