using System;

namespace BootCamp.Chapter
{
    class Application
    {
        readonly CredentialsManager manager;
        readonly UI ui;

        public Application(string credentialsFile)
        {
            manager = new CredentialsManager(credentialsFile);
            ui = new UI();
        }
        void Register()
        {
            Credentials inputCredential;
            bool registerError = false;
            do
            {
                string message = registerError ? "Username is taken" : "";
                inputCredential = ui.GetUserProfile("Register", message);

                registerError = manager.DoesUserExist(inputCredential.Username);
            } while (registerError);

            manager.Register(inputCredential);
        }

        void Login()
        {
            Credentials inputCredentials;
            bool notLoggedIn = false;
            do
            {
                string message = notLoggedIn ? "Incorrect username or password" : "";
                inputCredentials = ui.GetUserProfile("Login", message);

                notLoggedIn = !manager.Login(inputCredentials);
            } while (notLoggedIn);

            Console.WriteLine($"Logged in as {inputCredentials.Username}");
        }

        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Register: 1\nLogin: 2\n");
            ConsoleKeyInfo key;
            bool actionNotSelected = true;
            while (actionNotSelected)
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Register();
                        actionNotSelected = false;
                        break;
                    case ConsoleKey.D2:
                        Login();
                        actionNotSelected = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
