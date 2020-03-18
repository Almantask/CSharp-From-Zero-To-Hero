using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

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

            if (IsNameRegistered(user.UserName))
            {
                return false;
            }

            var encodedPassword = new Cryptography().Encode(user.Password);
            File.AppendAllText(CredentialsPath, user.UserName);
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
                username = PromptText("Enter username:");
            } while (string.IsNullOrEmpty(username.Trim()));

            string password = "";

            do
            {
                password = PromptPassword("Enter password:");
            } while (string.IsNullOrEmpty(password.Trim()));

            return new User(username, password);
        }

        private string PromptText(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private string PromptPassword(string message)
        {
            const char BackspaceKey = '\b';
            const char ReturnKey = '\r';
            const string PasswordBackspace = "\b\0\b\b\0\b";
            const string SmileyFace = "\x263A ";

            Console.WriteLine(message);
            var password = new StringBuilder();
            var enter = false;

            do
            {
                var key = Console.ReadKey(true);

                switch (key.KeyChar)
                {
                    case ReturnKey:
                        enter = false;
                        break;
                    case BackspaceKey:
                        Console.Write(PasswordBackspace);

                        if (password.Length > 0)
                        {
                            password.Remove(password.Length - 1, 1);
                        }

                        enter = true;
                        break;
                    default:
                        Console.OutputEncoding = Encoding.Unicode;
                        Console.Write(SmileyFace);
                        Console.OutputEncoding = Encoding.Default;
                        password.Append(key.KeyChar);
                        enter = true;
                        break;
                }
            } while (enter);

            Console.WriteLine("");
            return password.ToString();
        }

        private bool IsNameRegistered(string username)
        {
            var user = GetUser(username);

            if (user == null)
            {
                return false;
            }

            return true;
        }

        private bool AuthenticateUser(User user)
        {
            var storedUser = GetUser(user.UserName);

            if (storedUser == null || storedUser.Password != new Cryptography().Encode(user.Password))
            {
                return false;
            }

            return true;
        }

        private User GetUser(string username)
        {
            foreach (var user in GetCredentials())
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }

            return null;
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
                users = null;
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
