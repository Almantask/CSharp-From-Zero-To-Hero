using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class ConsoleUI
    {
        private CredentialsManager credentialsManager;

        public ConsoleUI(string filename)
        {
            credentialsManager = new CredentialsManager(filename);
        }

        public void Run()
        {
            PrintMenu();
        }

        private void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the unsecure Credentials manager.");
            Console.WriteLine("Please choose option 1 - 3 below.");
            Console.WriteLine("Press 1 to login.");
            Console.WriteLine("Press 2 to register new user.");
            Console.WriteLine("Press 3 to exit.");
            char choice;
            while (true)
            {
                var keyPressed = Console.ReadKey(true).KeyChar;
                if (keyPressed == '1' || keyPressed == '2' || keyPressed == '3')
                {
                    choice = keyPressed;
                    break;
                }
            }

            switch (choice)
            {
                case '1':
                    Login();
                    PrintMenu();
                    break;
                case '2':
                    NewUser();
                    PrintMenu();
                    break;
                case '3':
                    Console.WriteLine("Goodbye! Press a key to quit.");
                    Console.ReadKey(true);
                    break;
                default:
                    break;
            }
        }

        private void Login()
        {
            Console.Clear();
            Console.WriteLine("Login screen. Please enter your credentials.");

            string username = InputUserName();
            string password = InputPassword();

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and/or password may not be empty.");
                Console.WriteLine("Press any key to return to menu.");
                Console.ReadKey(true);
                return;
            }

            string userInfo = string.Format($"{username},{password}");

            if (Credentials.TryParse(userInfo, out Credentials credentials))
            {
                if (credentialsManager.Login(credentials))
                {
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    Console.WriteLine("User/Password incorrect.");
                }
            }
            else
            {
                Console.WriteLine("Error parsing credentials.");
            }

            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey(true);
        }

        private void NewUser()
        {
            Console.Clear();
            Console.WriteLine("New user. Please enter your desired credentials.");

            string username = InputUserName();
            string password = InputPassword();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Username and/or password may not be empty.");
                Console.WriteLine("Press any key to return to menu.");
                Console.ReadKey(true);
                return;
            }

            string userInfo = string.Format($"{username},{password}");

            if (Credentials.TryParse(userInfo, out Credentials credentials))
            {
                credentialsManager.Register(credentials);
            }
            else
            {
                Console.WriteLine("Failed to save user. Did you enter both username and password?");
            }

            Console.WriteLine("Press any key to return to menu.");
            Console.ReadKey(true);
        }

        private string InputUserName()
        {
            Console.Write("Input username: ");
            var username = Console.ReadLine();

            return username;
        }

        private string InputPassword()
        {
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Input password: ");
            char keyPressed;
            List<char> keyList = new List<char>();
            while (true)
            {
                keyPressed = Console.ReadKey(true).KeyChar;
                if (keyPressed == 13)
                {
                    break;
                }
                keyList.Add(keyPressed);
                Console.Write("\u263A");
            }

            Console.WriteLine();

            string password = new string(keyList.ToArray());
            password = CredentialsManager.EncodeToUnicode(password);

            return password;
        }
    }
}
