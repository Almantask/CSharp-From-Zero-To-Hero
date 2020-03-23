using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string CredentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            if (!StringOps.IsValid(credentialsFile))
            {
                throw new ArgumentNullException(nameof(credentialsFile));
            }

            CredentialsFile = credentialsFile;
        }

        private bool FindUser(Credentials user)
        {
            var found = false;

            foreach (var credential in GetCredentials())
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

            foreach (var credential in GetCredentials())
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

        private List<Credentials> GetCredentials()
        {
            string line;
            var internalCredentialsList = new List<Credentials>();

            StreamReader reader = null;
            try
            {
                reader = new StreamReader(CredentialsFile);
                while ((line = reader.ReadLine()) != null)
                {
                    if (Credentials.TryParse(line, out Credentials credentials))
                    {
                        internalCredentialsList.Add(credentials);
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

            return internalCredentialsList;
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