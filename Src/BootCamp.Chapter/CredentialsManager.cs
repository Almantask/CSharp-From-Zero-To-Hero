using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
    internal class CredentialsManager
    {
        private const string CredentialsPath = @"..\..\..\Database\Credentials.txt";

        public CredentialsManager()
        {
            if (!File.Exists(CredentialsPath))
            {
                File.WriteAllText(CredentialsPath, "");
            }
        }

        public void Register()
        {
            if (RegisterUser())
            {
                Console.WriteLine("You have successfully registered.\n");
            }
            else
            {
                Console.WriteLine("Sorry, your registration was unsuccessful.  The username is already taken.\n");
            }
        }

        private bool RegisterUser()
        {
            const string CarriageReturn = "\r\n";
            const string Delimiter = ",";

            var user = GetNameAndPassword();

            if (IsNameRegistered(user.Username))
            {
                return false;
            }

            var encodedPassword = new Cryptography().Encode(user.Password);
            File.AppendAllText(CredentialsPath, user.Username);
            File.AppendAllText(CredentialsPath, Delimiter);
            File.AppendAllText(CredentialsPath, encodedPassword);
            File.AppendAllText(CredentialsPath, CarriageReturn);

            return true;
        }

        public bool Login()
        {
            var user = GetNameAndPassword();

            if (AuthenticateUser(user))
            {
                Console.WriteLine("You have sucessfuly logged in.\n");
                return true;
            }

            Console.WriteLine("Sorry, we don't recognize you.\n");
            return false;
        }

        private User GetNameAndPassword()
        {
            string username = "";

            do
            {
                username = Utilities.PromptText("Enter username:");
            } while (string.IsNullOrEmpty(username.Trim()));

            string password = "";

            do
            {
                password = Utilities.PromptPassword("Enter password:");
            } while (string.IsNullOrEmpty(password.Trim()));

            return new User(username, password);
        }



        private bool IsNameRegistered(string username)
        {
            var user = GetUser(username);

            if (user.Username == null)
            {
                return false;
            }

            return true;
        }

        private bool AuthenticateUser(User user)
        {
            var storedUser = GetUser(user.Username);

            if (storedUser.Username == null || storedUser.Password != new Cryptography().Encode(user.Password))
            {
                return false;
            }

            return true;
        }

        private User GetUser(string username)
        {
            foreach (var user in GetCredentials())
            {
                if (user.Username == username)
                {
                    return user;
                }
            }

            return new User();
        }

        private List<User> GetCredentials()
        {
            var users = new List<User>();

            var credentials = File.ReadAllLines(CredentialsPath);

            foreach (var credential in credentials)
            {
                if (!TryCredentialsParse(credential, out var user))
                {
                    throw new InvalidDatabaseException("Unpexpected data found in credential database.");
                }

                users.Add(user);
            }

            return users;
        }

        private bool TryCredentialsParse(string credential, out User users)
        {
            var credentialData = credential.Split(",");

            if (!IsCredentialDataValid(credentialData))
            {
                users = new User();
                return false;
            }

            users = new User(credentialData[0], credentialData[1]);
            return true;
        }

        private bool IsCredentialDataValid(string[] credentialData)
        {
            if (credentialData.Length != 2)
            {
                return false;
            }

            return true;
        }
    }

}
