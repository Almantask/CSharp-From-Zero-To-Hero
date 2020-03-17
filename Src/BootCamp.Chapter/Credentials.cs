using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    public class Credentials
    {
        private readonly string credentialsFile = "credentials.db";

        public bool FindUser(User user)
        {
            string line;
            using StreamReader reader = new StreamReader(credentialsFile);
            bool found = false;
            while ((line = reader.ReadLine()) != null)
            {
                var isValid = User.TryParse(line, out User credentials);
                if (isValid && user.Equals(credentials))
                {
                    found = true;
                    break;
                }
            }
            reader.Close();
            return found;
        }

        public void AddUser(User user)
        {
            if (FindUser(user))
            {
                throw new UserAllreadyExistsException("User allready exists!");
            }

            using StreamWriter writer = new StreamWriter(credentialsFile, true);
            writer.WriteLine($"{user.Name},{user.Password}");
            writer.Close();
        }
    }
}