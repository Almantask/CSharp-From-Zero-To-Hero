using System;
using System.IO;
using System.Net;
using System.Text;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            if (string.IsNullOrEmpty(credentialsFile)) throw new ArgumentException("Credentials not be empty.");

            _credentialsFile = credentialsFile;
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            if (!Credentials.credentialsNotNull(credentials)) throw new ArgumentException("Credentials not be empty.");

            var readedCredentials = File.ReadAllLines(_credentialsFile);

            if (readedCredentials == null) return false;

            return CheckCredentials(credentials, readedCredentials);
        }

        private bool CheckCredentials(in Credentials credentials, string[] readedCredentials)
        {
            foreach (var readedCredential in readedCredentials)
            {
                var splittedCredential = readedCredential.Split(",");
                string credentialUsername = splittedCredential[0];

                string credentialPassword = ConvertByteArrayToString(splittedCredential[1]);

                Credentials righCredential = new Credentials(credentialUsername, credentialPassword);

                if ((righCredential.Username == credentials.Username) && (righCredential.Password == credentials.Password)) return true;
            }

            return false;
        }

        private string ConvertByteArrayToString(string stringByteArray)
        {
            var stringArray = stringByteArray.Split(" ");
            byte[] byteArray = new byte[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                byteArray[i] = Byte.Parse(stringArray[i]);
            }

            return Encoding.Unicode.GetString(byteArray); ;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            if (!Credentials.credentialsNotNull(credentials)) throw new ArgumentException("Credentials not be empty.");

            StringBuilder stringBuilder = CreateRegisterString(credentials);
            //D:\Desktop\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\CredentialsManager.cs
            using (var file = new StreamWriter(_credentialsFile, true))
            {
                file.WriteLine(stringBuilder.ToString());
            }

            //D:\Desktop\CSharp-From-Zero-To-Hero\Tests\BootCamp.Chapter.Tests\Input\Files\TomTom123Credentials.txt

        }

        private static StringBuilder CreateRegisterString(Credentials credentials)
        {
            byte[] unicodeBytes = Encoding.Unicode.GetBytes(credentials.Password);

            StringBuilder stringBuilder = new StringBuilder();
            foreach (var unicodeByte in unicodeBytes)
            {
                stringBuilder.Append($"{unicodeByte.ToString()} ");
            }

            stringBuilder.Remove(stringBuilder.Length - 1, 1);

            stringBuilder.Insert(0, $"{credentials.Username},");
            return stringBuilder;
        }
    }
}
