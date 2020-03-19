using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class Credentials
    {
        private const string Separator = ",";

        private readonly string CredentialsFile = "credentials.db";

        public Credentials()
        {
        }

        public Credentials(string credentialsFile)
        {
            CredentialsFile = credentialsFile ?? throw new ArgumentNullException(nameof(credentialsFile));
        }

        private bool FindUser(User user)
        {
            bool found = false;

            foreach (var credential in ReadDatabase())
            {
                if (credential.Equals(user))
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        private bool CheckUserExists(User user)
        {
            bool exists = false;

            foreach (var credential in ReadDatabase())
            {
                if (credential.Name == user.Name)
                {
                    exists = true;
                    break;
                }
            }

            return exists;
        }

        private bool AddUser(User user)
        {
            if (CheckUserExists(user))
            {
                throw new UserAllreadyExistsException("User already exists!");
            }

            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(CredentialsFile, true);
                writer.WriteLine(user.ToString());
            }
            catch (Exception)
            {
                throw new InvalidCredentialsDbFile($"There was an error while trying to work with {nameof(CredentialsFile)}");
            }
            finally
            {
                writer?.Close();
            }

            return true;
        }

        private List<User> ReadDatabase()
        {
            string line;
            var internalUserList = new List<User>();

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(CredentialsFile);
                while ((line = reader.ReadLine()) != null)
                {
                    if (TryParse(line, out User credentials))
                    {
                        internalUserList.Add(credentials);
                    }
                }
            }
            catch (Exception)
            {
                throw new InvalidCredentialsDbFile($"There was an error while trying to work with {nameof(CredentialsFile)}");
            }
            finally
            {
                reader?.Close();
            }

            return internalUserList;
        }

        private static bool TryParse(string input, out User user)
        {
            user = default;

            if (!StringOps.IsValid(input))
            {
                return false;
            }

            var fields = input.Split(Separator);
            const int fieldsNumber = 2;

            var isValid = fields.Length == fieldsNumber && StringOps.IsValid(fields[0]) && StringOps.IsValid(fields[1]);
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