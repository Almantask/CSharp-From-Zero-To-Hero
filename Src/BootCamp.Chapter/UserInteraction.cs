using System;

namespace BootCamp.Chapter
{
    public static class UserInteraction
    {
        private const string characterMask = "\u263A";

        private static readonly Credentials newCredentials = new Credentials();

        public static void DisplayMenu()
        {
            ConsoleInit();
            DisplayHeader("Main menu");

            Console.WriteLine("(1) Login");
            Console.WriteLine("(2) Register");
            Console.WriteLine();
            Console.WriteLine("(0) Exit!");

            ChooseMenu();
        }

        private static void ChooseMenu()
        {
            ConsoleKey pressedKey = Console.ReadKey(true).Key;
            if (pressedKey == ConsoleKey.D0)
            {
                return;
            }
            else if (pressedKey == ConsoleKey.D1)
            {
                Login();
            }
            else if (pressedKey == ConsoleKey.D2)
            {
                Register();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid option!");
                Wait();
            }
            DisplayMenu();
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

        private static void Login()
        {
            ConsoleInit(true);
            DisplayHeader("Login");

            var name = PromptName();
            var password = PromptPassword();

            Console.WriteLine();

            var testUser = new User(name, password);
            if (newCredentials.FindUser(testUser))
            {
                Console.WriteLine("Login succesfull!");
            }
            else
            {
                Console.WriteLine("Invalid credentials!");
            }

            Wait();
        }

        private static void Register()
        {
            ConsoleInit(true);
            DisplayHeader("Register");

            var name = PromptName();
            var password = PromptPassword();

            var newUser = new User(name, password);
            newCredentials.AddUser(newUser);

            Wait();
        }

        private static string PromptName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                throw new InvalidNameException("Name is not valid!");
            }

            return input;
        }

        private static string PromptPassword()
        {
            string password = default;
            while (true)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                if (pressedKey.Key != ConsoleKey.Backspace && pressedKey.Key != ConsoleKey.Enter)
                {
                    password += pressedKey.KeyChar;
                    Console.Write(characterMask);
                }
                else
                {
                    if (pressedKey.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password[0..^1];
                        Console.Write("\b \b");
                    }
                    else if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            return password;
        }
    }
}