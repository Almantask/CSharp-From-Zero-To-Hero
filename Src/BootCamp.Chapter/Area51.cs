using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Area51
    {
        private List<Credentials> loggedInAccounts = new List<Credentials>();
        readonly CredentialsManager credentialsManager = new CredentialsManager("Login.txt");
        const string login = "login";
        const string create = "create";
        const string see = "see";
        const string quit = "quit";
        public void Demo()
        {
            string answer = string.Empty;
            while (answer != quit)
            {
                answer = GetAnswerMainMenu();
                GoToPartOfProgram(answer);
            }
        }
        private string GetAnswerMainMenu()
        {

            string input = string.Empty;
            bool isLoopMainMenu = true;

            while (isLoopMainMenu)
            {
                Console.Clear();
                Console.WriteLine("Login\r\nCreate\r\nSee\r\nQuit");
                Console.Write("Please choose one: ");
                input = Console.ReadLine();
                isLoopMainMenu = AnswerParser(input);
            }
            return input.ToLower();

        }
        private void GoToPartOfProgram(string input)
        {
            switch (input)
            {
                case login:
                    Login();
                    break;
                case create:
                    CreateAccount();
                    break;
                case see:
                    See();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Terminating Program!");
                    Console.ReadKey();
                    break;
            }
        }
        private void Login()
        {
            bool isKeepLoopingLogin = true;

            while (isKeepLoopingLogin)
            {
                Console.Clear();
                Console.WriteLine("Create Account.");
                Console.Write("Login Name:");
                string username = Console.ReadLine();

                Console.Write("Password:");
                string password = Console.ReadLine();
                try
                {
                    if (Credentials.TryParse(username + "," + password, out Credentials credentials)
                    && credentialsManager.Login(credentials))
                    {
                        Console.Clear();
                        Console.WriteLine($"Logging {username} in now.");
                        Console.ReadKey();

                        loggedInAccounts.Add(credentials);
                        Console.WriteLine($"{username} now logged in. type See in main menu to check for logged in accounts.");
                        Console.ReadKey();
                        isKeepLoopingLogin = false;
                    }
                    else
                    {
                        isKeepLoopingLogin = AskTryAgain();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    isKeepLoopingLogin = AskTryAgain();
                }
                
            }
        }
        private bool AskTryAgain()
        {
            bool keeploopingUntillYesOrNo = true;

            while (keeploopingUntillYesOrNo)
            {
                Console.Clear();
                Console.WriteLine("Wrong Login information!");
                Console.WriteLine("Try Again? Y/N:");
                string answer = Console.ReadLine().ToLower();

                if (answer == "n")
                {
                    return false;
                }
                else if (answer == "y")
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateAccount()
        {
            bool isInputGood = false;

            while (!isInputGood)
            {
                try
                {
                    string name = AskForNameOrPasswordCreate("username");
                    string password = AskForNameOrPasswordCreate("password");

                    Credentials.TryParse(name + "," + password, out Credentials credentials);
                    credentialsManager.Register(credentials);

                    Console.WriteLine($"Account {name} created.");
                    Console.ReadKey();

                    isInputGood = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private string AskForNameOrPasswordCreate(string usernameOrPassword)
        {
            string input = string.Empty;
            bool isInLoopForNameOrPassword = true;

            while (isInLoopForNameOrPassword)
            {
                Console.Clear();
                Console.WriteLine("Create Account.");
                Console.Write($"Login {usernameOrPassword}:");
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"{usernameOrPassword} Cannot be empty.");
                    Console.ReadKey();
                }
                else
                {
                    isInLoopForNameOrPassword = false;
                }
            }
            return input;
        }

        private void See()
        {
            Console.Clear();
            Console.WriteLine("Showing all Accounts logged in:");

            foreach (Credentials credentials in loggedInAccounts)
            {
                Console.WriteLine($"{credentials.Username} + {credentials.Password}");
            }
            Console.ReadKey();
        }

        private bool AnswerParser(string input)
        {
            switch (input.ToLower())
            {
                case login:
                    return false;
                case create:
                    return false;
                case quit:
                    return false;
                case see:
                    return false;
                default:
                    return true;
            }
        }
    }
}
