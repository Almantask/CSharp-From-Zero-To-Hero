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
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            try
            {
                if (!DoesUserExist(credentials.Username))
                {
                    using (var writer = File.AppendText(_credentialsFile))
                    {
                        writer.WriteLine($"{credentials.Username} {credentials.Password}");
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

        // 2 ways to check if user exists 1) check if an instance of 'credentials' the same as user exists 2) check by username
        // all usernames will be unique so probably best bet
        private bool DoesUserExist(string username)
        {   
            using (var reader = File.OpenText(_credentialsFile))
            {
                string unique_credentials = reader.ReadLine();
                while (unique_credentials != null)
                {
                    if (unique_credentials.Split(" ")[0] == username)
                    {
                        return true;
                    }
                    else
                    {
                        reader.ReadLine();
                    }
                }
                return false;
            }
        } 


    }
}
