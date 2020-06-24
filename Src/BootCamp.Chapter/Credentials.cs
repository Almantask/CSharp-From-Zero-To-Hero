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
        public readonly EncodedPassword Password;

        public Credentials(string username, string password)
        {
            Username = username;
            EncodedPassword encodedPassword = new EncodedPassword(password);
            Password = encodedPassword;
        }

        public readonly struct EncodedPassword
        {
            private readonly byte[] encodedPassword { get; }
            
            public EncodedPassword(string user_password)
            {
                UnicodeEncoding unicode = new UnicodeEncoding();
                encodedPassword = unicode.GetBytes(user_password);
            }
        }

        // TODO: Implement properly.
        // assuming the 'struct' part of this homework is to implement the Unicode Encoding withing a password struct?

        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            return false;
        }
    }
}
