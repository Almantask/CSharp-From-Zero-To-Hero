using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            _credentialsFile = credentialsFile;
            if (!File.Exists(_credentialsFile))
            {
                File.Create(_credentialsFile).Close();
            }
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            string allLines = File.ReadAllText(_credentialsFile);

            if (String.IsNullOrEmpty(allLines))
            {
                return false;
            }

            string[] credentialsArray = allLines.Split(Environment.NewLine);

            for (int i = 0; i < credentialsArray.Length; i++)
            {
                if (String.IsNullOrWhiteSpace(credentialsArray[i]))
                {
                    continue;
                }

                string[] splitNameAndPassword = credentialsArray[i].Split(',');

                if (credentials.Username == splitNameAndPassword[0])
                {
                    if (credentials.Password == splitNameAndPassword[1])
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            string textToBeAdded = $"{credentials.Username},{credentials.Password}";//{Environment.NewLine}
            File.AppendAllLines(_credentialsFile, new string[] { textToBeAdded });
            //File.AppendAllText(_credentialsFile, textToBeAdded);
        }
    }
}
