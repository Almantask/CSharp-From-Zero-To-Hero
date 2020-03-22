using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string CredentialsFile = "credentials.db";

        public CredentialsManager()
        {
        }

        public CredentialsManager(string credentialsFile)
        {
            CredentialsFile = credentialsFile ?? throw new ArgumentNullException(nameof(credentialsFile));
        }

        private bool FindUser(Credentials user)
        {
            var found = false;

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

        private bool CheckUserExists(Credentials user)
        {
            var exists = false;

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

        private bool AddUser(Credentials user)
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

        private List<Credentials> ReadDatabase()
        {
            string line;
            var internalUserList = new List<Credentials>();

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(CredentialsFile);
                while ((line = reader.ReadLine()) != null)
                {
                    if (Credentials.TryParse(line, out Credentials credentials))
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

        public bool Register(Credentials user)
        {
            var tempUser = new Credentials(user.Name, StringOps.Encode(user.Password));
            return AddUser(tempUser);
        }

        public bool Login(Credentials user)
        {
            var tempUser = new Credentials(user.Name, StringOps.Encode(user.Password));
            return FindUser(tempUser);
        }
    }
}