using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class UserInteraction
    {
        private const string characterMask = "\u263A";
        private const string backspace = "\b \b";
        private static readonly CredentialsManager credentialsMananger = new CredentialsManager();

        public static void DisplayMainMenu()
        {
            ConsoleInit();
            DisplayHeader("Main menu");

            Console.WriteLine("(1) Login");
            Console.WriteLine("(2) Register");
            Console.WriteLine();
            Console.WriteLine("(0) Exit!");

            try
            {
                ChooseMenuItem();
            }
            catch (Exception ex) when (ex is InvalidCredentialsDbFile ||
                                       ex is InvalidNameException ||
                                       ex is InvalidPasswordException ||
                                       ex is UserAllreadyExistsException)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Wait();
                DisplayMainMenu();
            }
        }

        private static void ChooseMenuItem()
        {
            ConsoleKey pressedKey = Console.ReadKey(true).Key;
            if (pressedKey == ConsoleKey.D0 || pressedKey == ConsoleKey.NumPad0)
            {
                Environment.Exit(0);
            }
            else if (pressedKey == ConsoleKey.D1 || pressedKey == ConsoleKey.NumPad1)
            {
                LoginUser();
            }
            else if (pressedKey == ConsoleKey.D2 || pressedKey == ConsoleKey.NumPad2)
            {
                RegisterUser();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option!");
                Wait();
            }
            DisplayMainMenu();
        }

        private static void Wait()
        {
            Console.CursorVisible = false;
            Console.WriteLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }

        private static void ConsoleInit(bool cursorVisible = false)
        {
            Console.Clear();
            Console.CursorVisible = cursorVisible;
        }

        private static void DisplayHeader(string menuLocation)
        {
            Console.WriteLine("Credentials manager demo");
            Console.WriteLine(menuLocation);
            Console.WriteLine();
        }

        private static void LoginUser()
        {
            ConsoleInit();
            DisplayHeader("Login");

            var name = PromptName();
            var password = PromptPassword();

            Console.WriteLine();

            var testUser = new Credentials(name, password);
            TestLogin(testUser);

            Wait();
        }

        private static void TestLogin(Credentials testUser)
        {
            if (credentialsMananger.Login(testUser))
            {
                Console.WriteLine("Login successful!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }
        }

        private static void RegisterUser()
        {
            ConsoleInit();
            DisplayHeader("Register");

            var name = PromptName();
            var password = PromptPassword();

            Console.WriteLine();

            var newUser = new Credentials(name, password);
            TestRegistration(newUser);

            Wait();
        }

        private static void TestRegistration(Credentials newUser)
        {
            if (credentialsMananger.Register(newUser))
            {
                Console.WriteLine("Registration successful!");
            }
            else
            {
                Console.WriteLine("Registration failed, user already exists!");
            }
        }

        private static string PromptName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();

            if (!StringOps.IsValid(input))
            {
                throw new InvalidNameException("Name is not valid!");
            }

            return input;
        }

        private static string PromptPassword()
        {
            var password = new StringBuilder();

            Console.Write("Enter your password: ");

            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                var IsValidKey = pressedKey.Key != ConsoleKey.Backspace &&
                                   pressedKey.Key != ConsoleKey.Enter &&
                                   pressedKey.Key != ConsoleKey.Escape;

                if (IsValidKey)
                {
                    password.Append(pressedKey.KeyChar);
                    Console.Write(characterMask);
                }
                else if (pressedKey.Key == ConsoleKey.Backspace && password.Length != 0)
                {
                    password.Remove(password.Length - 1, 1);
                    Console.Write(backspace);
                }
                else if (pressedKey.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            if (password.Length == 0)
            {
                throw new InvalidPasswordException("Invalid password!");
            }
            return password.ToString();
        }
    }
}