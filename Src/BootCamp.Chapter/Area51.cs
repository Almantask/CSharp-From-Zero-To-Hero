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

            string answer = string.Empty;
            bool dontKnowAnswer = true;

            while (dontKnowAnswer)
            {
                Console.Clear();
                Console.WriteLine("Login\r\nCreate\r\nSee\r\nQuit");
                Console.Write("Please choose one: ");
                answer = Console.ReadLine();
                dontKnowAnswer = AnswerParser(answer);
            }
            return answer.ToLower();

        }
        private void GoToPartOfProgram(string answer)
        {
            switch (answer)
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
            bool wrongAnswer = true;

            while (wrongAnswer)
            {
                Console.Clear();
                Console.WriteLine("Create Account.");
                Console.Write("Login Name:");
                string name = Console.ReadLine();

                Console.Write("Password:");
                string password = Console.ReadLine();
                if (Credentials.TryParse(name + "," + password, out Credentials credentials) 
                    && credentialsManager.Login(credentials))
                {
                    Console.Clear();
                    Console.WriteLine($"Logging {name} in now.");
                    Console.ReadKey();

                    loggedInAccounts.Add(credentials);
                    Console.WriteLine($"{name} now logged in. type See in main menu to check for logged in accounts.");
                    Console.ReadKey();
                    wrongAnswer = false;
                }
                else
                {
                    wrongAnswer = AskTryAgain();
                }
            }
        }
        private bool AskTryAgain()
        {
            bool again = true;
            while (again)
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
            bool wrongAnswer = true;

            while (wrongAnswer)
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
                    wrongAnswer = false;
                }
            }
            return input;
        }

        private void See()
        {
            Console.WriteLine("Showing all Accounts logged in:");
            foreach (Credentials credentials in loggedInAccounts)
            {
                Console.WriteLine($"{credentials.Username} + {credentials.Password}");
            }
            Console.ReadKey();

        }

        private bool AnswerParser(string answer)
        {
            switch (answer.ToLower())
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
