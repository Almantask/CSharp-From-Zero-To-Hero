using System;
using System.Collections.Generic;
using System.Text;

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

        public bool Login(Credentials credentials)
        {
            FileHandler fileHandler = new FileHandler(_credentialsFile);
            List<string> fileData = fileHandler.ReadFromFile();

            for (int i = 0; i < fileData.Count; i++)
            {
                string[] savedUser = fileData[i].Split(",");
                if(savedUser[0] == credentials.Username && savedUser[1] == credentials.Password)
                {
                    return true;
                }
            }

            return false;
        }

        public void Register(Credentials credentials)
        {
            if(string.IsNullOrEmpty(credentials.Username) || string.IsNullOrEmpty(credentials.Password))
            {
                throw new ArgumentException();
            }

            FileHandler fileHandler = new FileHandler(_credentialsFile);
            fileHandler.AppendToFile(credentials.ConvertCredentialsToString());
        }

        private List<Credentials> StringToCredentials(List<string> fileData)
        {
            List<Credentials> result = new List<Credentials>();

            foreach (var line in fileData)
            {
                if(Credentials.TryParse(line, out Credentials credentials))
                {
                    result.Add(credentials);
                }
                else
                {
                    throw new FileIOException("File data corrupt or missing, error parsing credentials.", new Exception());
                }
            }

            return result;
        }

        public static string EncodeToUnicode(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return "";
            }
            StringBuilder stringBuilder = new StringBuilder();
            var encodedString = Encoding.Unicode.GetBytes(password);

            for (int i = 0; i < encodedString.Length - 1; i++)
            {
                stringBuilder.Append(encodedString[i].ToString());
                stringBuilder.Append(" ");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);
            return stringBuilder.ToString();
        }
    }
}
