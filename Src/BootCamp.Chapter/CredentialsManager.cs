using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using static BootCamp.Chapter.Credentials;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;

        public CredentialsManager(string credentialsFile)
        {
            if (File.Exists(credentialsFile))
            {
                _credentialsFile = credentialsFile;
            }
            else
            {
                throw new ArgumentException("This file does not exist");
            }
        }

        public bool Login(Credentials credentials)
        {
            if (AreCredentialsValid(credentials))
            {
                if (DoesUserExist(credentials.Username))
                {
                    Console.WriteLine("Users Exists, Login is correct!");
                    return UserCredentialsMatch(credentials);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Register(Credentials credentials)
        {
            try
            {
                if (!DoesUserExist(credentials.Username))
                {
                    using (var writer = File.AppendText(_credentialsFile))
                    {
                        writer.WriteLine($"{credentials.Username},{credentials.Password}");
                        Console.WriteLine($"Registration was successful, {credentials.Username}!");
                    }
                }
                else
                {
                    throw new UserExistsException();
                }
            }
            catch(UserExistsException msg)
            {
                Console.WriteLine(msg);
            }  
        }

        private bool UserCredentialsMatch(Credentials credentials)
        {
            using (var reader = File.OpenText(_credentialsFile))
            {
                string unique_credentials = reader.ReadLine();
                while (unique_credentials != null)
                {
                    bool usernameCheck = unique_credentials.Split(",")[0] == credentials.Username;
                    bool passwordCheck = unique_credentials.Split(",")[1].Replace(" ", "") == credentials.Password;
                    if (usernameCheck && passwordCheck)
                    {
                        Console.WriteLine($"Credentials Match! Welcome back {credentials.Username}!");
                        return true;
                    }
                    else if (unique_credentials == null)
                    {
                        return false;
                    }
                    else
                    {
                        unique_credentials = reader.ReadLine();
                    }
                }
                return false;
            }
        }

        private bool DoesUserExist(string username)
        {
            using (var reader = File.OpenText(_credentialsFile))
            {
                string unique_credentials = reader.ReadLine();
                while (unique_credentials != null)
                {
                    if (unique_credentials.Split(",")[0] == username)
                    { 
                        return true;
                    }
                    else if (unique_credentials == null)
                    {
                        return false;
                    }
                    else
                    {
                        unique_credentials = reader.ReadLine();
                    }
                }
                return false;
            }
        }
        
        protected bool AreCredentialsValid(Credentials credentials)
        {
            var credentialsStr = $"{credentials.Username},{credentials.Password}";
            if (TryParse(credentialsStr, out _))
            {
                return true;
            }
            else
            {
                return false;
            } 
        }
    }
}
