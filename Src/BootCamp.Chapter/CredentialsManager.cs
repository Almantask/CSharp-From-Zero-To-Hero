using System;
using System.Collections.Generic;
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
                throw new ArgumentException();
            }
            _credentialsFile = credentialsFile;
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            var existingCredentials = GetCredentials();

            for (int i = 0; i < existingCredentials.Count; i++)
            {
                if (credentials.Equals(existingCredentials[i]))
                {
                    return true;
                }
            }

            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            File.AppendAllText(_credentialsFile, credentials.ToFile);
        }

        List<Credentials> GetCredentials()
        {
            List<Credentials> creds = new List<Credentials>();

            string fileContent = File.ReadAllText(_credentialsFile);
            string[] unparsedCredentials = fileContent.Split(Environment.NewLine);

            for (int i = 0; i < unparsedCredentials.Length; i++)
            {
                if (Credentials.TryParse(unparsedCredentials[i], out Credentials c))
                {
                    creds.Add(c);
                }
            }

            return creds;
        }

        public bool DoesUserExist(string name)
        {
            var creds = GetCredentials();
            for (int i = 0; i < creds.Count; i++)
            {
                if (creds[i].Username == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
