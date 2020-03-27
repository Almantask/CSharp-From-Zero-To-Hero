using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Area51
    {
        private List<Account> loggedInAccounts = new List<Account>();
        readonly LoginAndRedister loginAndRegister = new LoginAndRedister();
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
                if (loginAndRegister.Login(name, password, out Account account))
                {
                    Console.Clear();
                    Console.WriteLine($"Logging {name} in now.");
                    Console.ReadKey();

                    loggedInAccounts.Add(account);
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

                if ( answer == "n")
                {
                    return false;
                }
                else if (answer == "y" )
                {
                    return true;
                }
            }
            return false;
        }

        private void CreateAccount()
        {
            string name = AskForName();
            string password = AskForPassword();
            loginAndRegister.Create(name, password);
        }

        private string AskForName()
        {
            string name = string.Empty;
            bool wrongAnswer = true;

            while (wrongAnswer)
            {
                Console.Clear();
                Console.WriteLine("Create Account.");
                Console.Write("Login Name:");
                name = Console.ReadLine();

                if (loginAndRegister.AccountNameExists(name))
                {
                    Console.WriteLine($"{name} already exists as a name please choose a new one.");
                    Console.ReadKey();
                }
                else if (!Checks.IsNameValid(name))
                {
                    Console.WriteLine($"{name} must be more than 2 and less than 15 characters.\r\n" +
                        $" It Cannot contain any non alphabetical characters.");
                    Console.ReadKey();
                }
                else
                {
                    wrongAnswer = false;
                }
            }
            return name;
        }
        private string AskForPassword()
        {
            string password = string.Empty;
            bool falsePassword = true;

            while (falsePassword)
            {
                Console.Clear();
                Console.WriteLine("Create Account.");
                Console.WriteLine("Login Name:*****");
                Console.Write("Password:");
                password = Console.ReadLine();

                if (!Checks.IsPasswordValid(password))
                {
                    Console.WriteLine($"Password must be more than 7 and less than 50 characters.\r\n" +
                        $" It must contain at least one Capital letter, 1 lowercase letter, 1 number and 1 special character.");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Please rewrite password:");

                    if (password != Console.ReadLine())
                    {
                        Console.WriteLine("Passwords do not match try again!");
                        Console.ReadKey();
                    }
                    else
                    {
                        falsePassword = false;
                    }
                }
            }
            return password;
        }
        private void See()
        {
            Console.Clear();
            Console.WriteLine("Showing all Accounts in the system:");
            loginAndRegister.ShowAllAccounts();

            Console.WriteLine("Showing all Accounts logged in:");
            foreach (Account account in loggedInAccounts)
            {
                Console.WriteLine($"{account.Name} + {account.Password}");
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
