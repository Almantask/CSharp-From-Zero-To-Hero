using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            if (string.IsNullOrEmpty(credentialsFile))
            {
                throw new ArgumentException("File path cannot be empty");
            }
            _credentialsFile = credentialsFile;
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            string credentialsToFind = credentials.GetCredentials();

            string fileContent = File.ReadAllText(_credentialsFile);
            string[] credentialsInFile = fileContent.Split(Environment.NewLine);

            foreach (var credential in credentialsInFile)
            {
                if (credential.Equals(credentialsToFind)) return true;
            }

            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            string credentialsToAppend = credentials.GetCredentials();

            if (File.Exists(_credentialsFile) && !String.IsNullOrEmpty(File.ReadAllText(_credentialsFile)))
            {
                credentialsToAppend = $"{Environment.NewLine}{credentialsToAppend}";
            }

            File.AppendAllText(_credentialsFile, credentialsToAppend);
        }

        private bool CheckIfCredentialsExistInFile()
        {
            return false;
        }
    }
}
