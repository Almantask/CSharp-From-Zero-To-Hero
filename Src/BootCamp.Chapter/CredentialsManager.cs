using System.Text;
using System.IO;
using BootCamp.Chapter.Exceptions;

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
            
        }

        private void AddUser(Credentials credentials)
        {
            if (!File.Exists(_credentialsFile))
                throw new InvalidDatabaseFileException("Database file does not exist or cannot be reached.");

            using (StreamWriter streamWriter = new StreamWriter(_credentialsFile, true))
            {
                streamWriter.WriteLine(credentials.ToString());
            }
        }
    }
}
