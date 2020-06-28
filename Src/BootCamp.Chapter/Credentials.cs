using System;
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
            if(String.IsNullOrWhiteSpace(username) || String.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Both Username and Password cannot be empty");
            }
            else
            {
                Username = username;
                EncodedPassword tempPassword = new EncodedPassword(password);
                Password = ByteToString(tempPassword.tempPassword);
            }     
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
        // try to improve as unhappy with the current implementation


        public static bool TryParse(string input, out Credentials credentials)
        {   
            credentials = default;

            if (String.IsNullOrWhiteSpace(input))
                return false;

            var splitInput = input.Split(",");

            if (splitInput.Length == 0 || splitInput.Length == 1)
                return false;

            var isValid = !String.IsNullOrWhiteSpace(splitInput[0]) || !String.IsNullOrWhiteSpace(splitInput[1]);

            if (!isValid)
                return false;

            credentials = new Credentials(splitInput[0], splitInput[1]);
            return true;
        }
    }
}
