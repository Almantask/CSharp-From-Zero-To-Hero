using System;
using System.IO;
using static BootCamp.Chapter.Credentials;

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
                        writer.WriteLine($"{credentials.Username} {credentials.Password.ToString()}");
                        Console.WriteLine($"Registration was successful {credentials.Username}");
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

        // refactor into a separate class as this functionality can be made generic i.e just opening a file and sorting through
        // same functionlity will be needed for the loading of a user in addition to the registation
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

        /*
        private bool UserCredentialsMatch(Credentials credentials)
        {
            using (var reader = File.OpenText(_credentialsFile))
            {
                string unique_credentials = reader.ReadLine();
                while (unique_credentials != null)
                {
                    if (!credentials.TryParse(unique_credentials))
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
        */


    }
}
