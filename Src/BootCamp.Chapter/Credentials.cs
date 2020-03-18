using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class Credentials
    {
        private const string Separator = ",";

        private readonly string credentialsFile = "credentials.db";

        private bool FindUser(User user)
        {
            string line;
            bool found = false;

            StreamReader reader;
            try
            {
                reader = new StreamReader(credentialsFile);
                while ((line = reader.ReadLine()) != null)
                {
                    var isValid = TryParse(line, out User credentials);
                    if (isValid && user.Equals(credentials))
                    {
                        found = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidCredentialsDbFile($"There was an error while trying to work with {credentialsFile}");
            }
            reader?.Close();
            return found;
        }

        private bool AddUser(User user)
        {
            if (FindUser(user))
            {
                throw new UserAllreadyExistsException("User allready exists!");
            }
            StreamWriter writer;
            try
            {
                writer = new StreamWriter(credentialsFile, true);
                writer.WriteLine($"{user.Name},{user.Password}");
            }
            catch (Exception ex)
            {
                throw new InvalidCredentialsDbFile($"There was an error while trying to work with {credentialsFile}", ex);
            }

            writer?.Close();

            writer.Close();
            return true;
        }

        private static bool TryParse(string input, out User user)
        {
            user = default;

            if (StringOps.IsValid(input))
            {
                return false;
            }

            var fields = input.Split(Separator);
            const int fieldsNumber = 2;

            var isValid = fields.Length == fieldsNumber || StringOps.IsValid(fields[0]) || StringOps.IsValid(fields[1]);
            if (!isValid)
            {
                return false;
            }

            user = new User(fields[0], fields[1]);
            return true;
        }

        public bool Register(User user)
        {
            var tempUser = new User(user.Name, StringOps.Encode(user.Password));
            return AddUser(tempUser);
        }

        public bool Login(User user)
        {
            var tempUser = new User(user.Name, StringOps.Encode(user.Password));
            return FindUser(tempUser);
        }
    }
}