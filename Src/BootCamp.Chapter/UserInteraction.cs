using System;
using System.Text;

namespace BootCamp.Chapter
{
    public static class UserInteraction
    {
        private const string characterMask = "\u263A";
        private const string backspace = "\b \b";
        private static readonly Credentials newCredentials = new Credentials();

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
                ChooseMenu();
            }
            catch (InvalidCredentialsDbFile ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UserAllreadyExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
                LoginUser();
            }
            else if (pressedKey == ConsoleKey.D2)
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

            var testUser = new User(name, password);
            TestLogin(testUser);

            Wait();
        }

        private static void TestLogin(User testUser)
        {
            if (newCredentials.Login(testUser))
            {
                Console.WriteLine("Login succesfull!");
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

            var newUser = new User(name, password);
            TestRegistration(newUser);

            Wait();
        }

        private static void TestRegistration(User newUser)
        {
            if (newCredentials.Register(newUser))
            {
                Console.WriteLine("Registration succesfull!");
            }
            else
            {
                Console.WriteLine("Registration failed, user allready exists!");
            }
        }

        private static string PromptName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();

            if (StringOps.IsValid(input))
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
                if (pressedKey.Key != ConsoleKey.Backspace && pressedKey.Key != ConsoleKey.Enter && pressedKey.Key != ConsoleKey.Escape)
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