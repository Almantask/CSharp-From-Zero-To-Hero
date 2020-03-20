using System;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Program
    {
        private readonly static CredentialsManager credentialsManager = new CredentialsManager();

        public static void Main()
        {
            Console.WriteLine("Welcome to the Login and Register features.\n");

            const string RegisterOption = "1";
            const string LoginOption = "2";

            string option;
            var isLoginSuccessful = false;

            do
            {
                do
                {
                    option = PromptText("Which option do you want ('1' for Register, '2' for Login)?");
                } while (option != RegisterOption && option != LoginOption);

                var credentials = ReadCredentials();

                if (option == RegisterOption)
                {
                    Register(credentials);
                }
                else //option == Login
                {
                    Login(credentials);
                }
            } while (!isLoginSuccessful);

            Console.WriteLine("The program has finished, because you have successfully logged in.");
        }

        private static void Register(Credentials credentials)
        {
            if (credentialsManager.Register(credentials))
            {
                Console.WriteLine("You have successfully registered.\n");
            }
            else
            {
                Console.WriteLine("Sorry, your registration was unsuccessful.  The username is already taken.\n");
            }
        }

        private static void Login(Credentials credentials)
        {
            if (credentialsManager.Login(credentials))
            {
                Console.WriteLine("You have sucessfuly logged in.\n");
            }
            else
            {
                Console.WriteLine("Sorry, we don't recognize you.\n");
            }
        }

        private static Credentials ReadCredentials()
        {
            string username;

            do
            {
                username = PromptText("Enter username:");
            } while (string.IsNullOrEmpty(username.Trim()));

            string password;

            do
            {
                password = PromptPassword("Enter password:");
            } while (string.IsNullOrEmpty(password.Trim()));

            return new Credentials(username, password);
        }

        private static string PromptText(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        private static string PromptPassword(string message)
        {
            const char BackspaceKey = '\b';
            const char ReturnKey = '\r';
            const string PasswordBackspace = "\b\0\b\b\0\b";
            const string SmileyFace = "\x263A ";

            Console.WriteLine(message);
            var password = new StringBuilder();
            bool enter;

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
    }
}
