using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;
        private readonly List<Credentials> _credentials = new List<Credentials>();

        public CredentialsManager(string credentialsFile)
        {
            if (string.IsNullOrEmpty(credentialsFile))
                throw new ArgumentException("Credentials file path not given");

            _credentialsFile = credentialsFile;
        }

        private void LoadCredentialsFromFile()
        {
            using var reader = new StreamReader(_credentialsFile);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                bool credsAreValid = Credentials.TryParse(line, out Credentials creds);

                if (credsAreValid)
                {
                    _credentials.Add(creds);
                }
            }
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            LoadCredentialsFromFile();

            foreach (var creds in _credentials)
            {
                if (credentials.Equals(creds))
                    return true;
            }

            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            using var reader = new StreamReader(_credentialsFile);

            bool alreadyContainsLine = reader.ReadLine() != null;
            reader.Close();

            using var writer = new StreamWriter(_credentialsFile, true);
            if (alreadyContainsLine)
                writer.Write("\n");
            writer.WriteLine($"{credentials.Username},{credentials.Password}");
        }
    }
}