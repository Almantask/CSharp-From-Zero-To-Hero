using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    internal class CredentialsManager
    {
        private const string CredentialsPath = @"..\..\..\Database\Credentials.txt";

        public CredentialsManager()
        {
            if (!File.Exists(CredentialsPath))
            {
                File.Create(CredentialsPath).Dispose();
            }
        }

        public bool Register(Credentials credentials)
        {
            const string Delimiter = ",";

            if (IsNameRegistered(credentials.Username))
            {
                return false;
            }

            var encodedPassword = new Cryptography().Encode(credentials.Password);
            File.AppendAllText(CredentialsPath, credentials.Username);
            File.AppendAllText(CredentialsPath, Delimiter);
            File.AppendAllText(CredentialsPath, encodedPassword);
            File.AppendAllText(CredentialsPath, Environment.NewLine);

            return true;
        }

        private bool IsNameRegistered(string username)
        {
            var credentials = GetStoredCredentials(username);

            if (credentials.Username == null)
            {
                return false;
            }

            return true;
        }

        public bool Login(Credentials credentials)
        {
            var storedCredentials = GetStoredCredentials(credentials.Username);

            if (storedCredentials.Username == null || storedCredentials.Password != new Cryptography().Encode(credentials.Password))
            {
                return false;
            }

            return true;
        }
               
        private Credentials GetStoredCredentials(string username)
        {
            foreach (var credentials in ReadCredentials())
            {
                if (credentials.Username == username)
                {
                    return credentials;
                }
            }

            return new Credentials();
        }

        private List<Credentials> ReadCredentials()
        {
            var credentialsList = new List<Credentials>();

            var readCredentials = File.ReadAllLines(CredentialsPath);

            foreach (var credentials in readCredentials)
            {
                if (!TryCredentialsParse(credentials, out var parsedCredentials))
                {
                    throw new InvalidDatabaseException("Unpexpected data found in credentials database.");
                }

                credentialsList.Add(parsedCredentials);
            }

            return credentialsList;
        }

        private bool TryCredentialsParse(string credentials, out Credentials parsedCredentials)
        {
            var credentialsData = credentials.Split(",");

            if (!IsCredentialsDataValid(credentialsData))
            {
                parsedCredentials = new Credentials();
                return false;
            }

            parsedCredentials = new Credentials { Username = credentialsData[0], Password = credentialsData[1] };
            return true;
        }

        private bool IsCredentialsDataValid(string[] credentialsData)
        {
            if (credentialsData.Length != 2)
            {
                return false;
            }

            return true;
        }
    }
}
