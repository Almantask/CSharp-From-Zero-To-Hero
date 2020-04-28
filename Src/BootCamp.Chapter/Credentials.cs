using System;
using System.Text;

namespace BootCamp.Chapter
{
    // TODO: make a struct and add validation and other needed methods (if needed)
    public readonly struct Credentials
    {
        public string Username { get; }
        public  string Password{ get; }

        public Credentials(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Invalid username or password.");
            }
            Username = username;
            Password = EncryptPassword(password);
        }
        
        // TODO: Implement properly.
        public static bool TryParse(string input, out Credentials credentials)
        {
            credentials = default;
            if (string.IsNullOrEmpty(input)) return false;
            
            var loginInfo = input.Split(',');
            if (loginInfo.Length != 2) return false;
            
            var username = loginInfo[0];
            var password = loginInfo[1];
            if (!IsUsernameValid(username)) return false;
            if (username.Contains(',') || password.Contains(',')) return false;
            
            credentials = new Credentials(username, password);
            return true;
        }
        
        /// <summary>
        /// Encrypt password to byte using Unicode table.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string EncryptPassword(string password)
        {
            var encodedBytes = Encoding.Unicode.GetBytes(password);
            var encodedPassword = new StringBuilder();
            encodedPassword.AppendJoin(' ', encodedBytes);

            return encodedPassword.ToString();
        }
        
        /// <summary>
        /// Check if username contain only alphanumeric character.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private static bool IsUsernameValid(string username)
        {
            foreach (var letter in username)
            {
                if (!char.IsLetter(letter) && !char.IsNumber(letter))
                {
                    return false;
                }
            }

            return true;
        }
        
    }
}
