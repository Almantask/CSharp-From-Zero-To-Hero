using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public string Username;
        public string Password;

        public Credentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            if(input.Contains(","))
            {
                var list = new List<string>(input.Split(","));
                if (list.Count != 2)
                    return false;
                else
                {
                    credentials.Username = list[0];
                    credentials.Password = list[1];
                    return true;
                }
            }          
            return false;
        }
        public override bool Equals(object obj)
        {
            var credit = obj as Credentials;
            if (credit == null)
                return false;
            if (this.Username == credit.Username && this.Password == credit.Password)
                return true;
            return false;
            
        }
        private void CheckInput(string a,string b)
        {
            if(string.IsNullOrEmpty(a)||string.IsNullOrEmpty(b))
            {
                throw new ArgumentException("Input is invalid.");
            }
        }
        public override string ToString()
        {
            return $"{Username}_{Password}";
        }
    }
}
