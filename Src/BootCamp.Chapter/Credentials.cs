using System;
using System.Text;

namespace BootCamp.Chapter
{
    public struct Credentials
    {
        public string Username;
        public string Password;

        public Credentials(string username, string password)
        {
            CheckForNullAndEmpty(username, password);

            Username = username;
            Password = EncodePasswordToString(password);
        }

        private static void CheckForNullAndEmpty(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Username or password can't be empty.");
            }
        }

        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            string[] splitInput = input.Split(',');

            if (splitInput.Length != 2)
            {
                return false;
            }

            credentials = new Credentials(splitInput[0], splitInput[1]);

            return true;
        }

        public static string EncodePasswordToString(string password)
        {
            StringBuilder sb = new StringBuilder();
            byte[] bytePassword = Encoding.Unicode.GetBytes(password);

            for (int i = 0; i < bytePassword.Length; i++)
            {
                sb.Append(bytePassword[i].ToString());
            }

            return sb.ToString();

            //var bytes = Encoding.Unicode.GetBytes(password);
            //return new string(Encoding.Unicode.GetChars(bytes));
        }
    }
}
