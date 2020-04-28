using System;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            // Create file if not exist
            File.AppendAllText(credentialsFile, "");
            _credentialsFile = credentialsFile;
        }

        public bool Login(Credentials credentials)
        {
            if (!IsUserRegistered(credentials.Username, out var password)) return false;
            return password.Equals(credentials.Password);
        }

        /// <summary>
        /// Register a Credentials type account to file.
        /// If username already exist in _credentialsFile, do nothing
        /// </summary>
        /// <param name="credentials"></param>
        public void Register(Credentials credentials)
        {
            if (IsUserRegistered(credentials.Username, out _))
            {
                Console.WriteLine("Username already taken.");
                return;
            }

            
            var loginInfo = $"{credentials.Username},{credentials.Password}";
            if (!string.IsNullOrEmpty(File.ReadAllText(_credentialsFile)))
            {
                loginInfo = Environment.NewLine + loginInfo;
            }
            File.AppendAllText(_credentialsFile, loginInfo);
        }

        
        /// <summary>
        /// Check if username exist, if true, out password to compare.
        /// PS: All password in _credentialsFile is already encrypted.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool IsUserRegistered(string username, out string password)
        {
            var credentials = File.ReadAllLines(_credentialsFile);
            password = default;
            
            foreach (var credential in credentials)
            {
                var loginInfo = credential.Split(',');
                if (loginInfo.Length != 2) return false;

                if (!loginInfo[0].Equals(username)) continue;
                password = loginInfo[1];
                return true;
            }
            
            return false;
        }
    }
}
