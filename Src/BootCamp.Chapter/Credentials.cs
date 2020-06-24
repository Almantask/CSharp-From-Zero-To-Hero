using System.ComponentModel;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public class Credentials
    {
        public readonly string Username;
        public readonly string Password;

        public Credentials(string username, string password)
        {
            Username = username;
            EncodedPassword tempPassword = new EncodedPassword(password);
            Password = ByteToString(tempPassword.tempPassword);
        }

        public readonly struct EncodedPassword
        {
            public readonly byte[] tempPassword { get; }
            
            public EncodedPassword(string user_password)
            {
                UnicodeEncoding unicode = new UnicodeEncoding();
                tempPassword = unicode.GetBytes(user_password);
            }
        }

       
        private string ByteToString(byte[] tempPassword)
        {
            var encodedPassword = new StringBuilder();
            foreach (var character in tempPassword)
            {
                encodedPassword.Append(character);
            }

            return encodedPassword.ToString();
        }
        

        // TODO: Implement properly.
        // split incoming string (contains both the Username and Encoded Password
        // check that they are legitimate, if so, package into a new Credential

        public bool TryParse(string input, out Credentials credentials)
        {
            // initial setting, will be overwritten later on if the check is valid
            credentials = default;
            return false;
        }
    }
}
