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

        public bool Login(Credentials credentials)
        {
            string allLines = File.ReadAllText(_credentialsFile);

            if (String.IsNullOrEmpty(allLines))
            {
                return false;
            }

            return IsUsernameAndPasswordCorrect(credentials, allLines);
        }

        private static bool IsUsernameAndPasswordCorrect(Credentials credentials, string allLines)
        {
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
                }
            }
            return false;
        }

        public void Register(Credentials credentials)
        {
            string textToBeAdded;

            if (string.IsNullOrEmpty(File.ReadAllText(_credentialsFile)))
            {
                textToBeAdded = $"{credentials.Username},{credentials.Password}";
            }
            else
            {
                textToBeAdded = $"{Environment.NewLine}{credentials.Username},{credentials.Password}";
            }
            
            File.AppendAllText(_credentialsFile,textToBeAdded);
        }
    }
}
