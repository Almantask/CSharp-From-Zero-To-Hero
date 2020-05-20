using System.Text;
using System.IO;
using BootCamp.Chapter.Exceptions;
using System.Collections.Generic;
using System;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            if (string.IsNullOrWhiteSpace(credentialsFile))
                throw new ArgumentException("Credentials file cannot be null.");

            _credentialsFile = credentialsFile;
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            var encodedCredentials = new Credentials(credentials.Username, Encoder.Encode(credentials.Password));
            AddUser(encodedCredentials);
        }

        private void AddUser(Credentials credentials)
        {
            if (Exists(credentials))
                throw new UserAlreadyExistsException($"{credentials.Username} already exists in database.");

            if (!File.Exists(_credentialsFile))
                throw new InvalidDatabaseFileException("Database file does not exist or cannot be reached.");

            using (StreamWriter streamWriter = new StreamWriter(_credentialsFile, true))
            {
                streamWriter.WriteLine(credentials.ToString());
            }
        }

        private bool Exists(Credentials credentials)
        {
            foreach (var registeredCredential in GetCredentials())
            {
                if (registeredCredential.Username == credentials.Username)
                    return true;
            }

            return false;
        }

        private List<Credentials> GetCredentials()
        {
            var credentialsList = new List<Credentials>();

            using (StreamReader streamReader = new StreamReader(_credentialsFile))
            {
                string currentLine;
                while ((currentLine = streamReader.ReadLine()) != null)
                {
                    if (Credentials.TryParse(currentLine, out Credentials credentials))
                        credentialsList.Add(credentials);
                }
            }

            return credentialsList;
        }
    }
}
