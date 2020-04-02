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
                throw new ArgumentException("CredentialsFile name cannot be empty.");
            }

            _credentialsFile = credentialsFile;

            if (!File.Exists(_credentialsFile))
            {
                File.Create(_credentialsFile).Close();
            }
        }

        public bool Login(Credentials credentials)
        {
            string[] credentialsArray = File.ReadAllLines(_credentialsFile);

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

                        Console.Clear();
                        Console.WriteLine($"Logging {splitNameAndPassword[0]} in now.");
                        Console.ReadKey();

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
                textToBeAdded = $"{credentials.ToString()}";
            }
            else
            {
                textToBeAdded = $"{Environment.NewLine}{credentials.ToString()}";
            }

            File.AppendAllText(_credentialsFile, textToBeAdded);
        }
    }
}
