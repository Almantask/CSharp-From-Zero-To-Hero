using System;
using System.Text;

namespace BootCamp.Chapter
{
    public class PasswordManager
    {
        public void DisplayMenu()
        {
            var menuOptions = new[] {"Login", "Register", "Exit"};
            var menu = new InteractiveMenu();
            var option = menu.Build(menuOptions);

            if (option == 0) DisplayLoginMenu();
            if (option == 1) DisplayRegisterMenu();
        }

        private void DisplayRegisterMenu()
        {
            Console.Clear();
            Console.WriteLine("Enter your username,password | Eg. \"foo,bar\"");
            var accountInfo = Console.ReadLine();
            if (!Credentials.TryParse(accountInfo, out var credential))
            {
                Console.WriteLine("Invalid account info.");
                return;
            }

            Console.WriteLine("Adding account to manager");
            var manager = new CredentialsManager(@"Passwords.txt");
            manager.Register(credential);
        }

        private void DisplayLoginMenu()
        {
            Console.WriteLine("Enter your username:");
            var username = Console.ReadLine();
            Console.WriteLine("Enter your password:");
            var password = InputPassword();

            if (!Credentials.TryParse($"{username},{password}", out var account))
            {
                Console.WriteLine("Invalid username/password.");
                return;
            }
            
            var manager = new CredentialsManager(@"Passwords.txt");
            if (!manager.Login(account))
            {
                Console.WriteLine("Incorrect username/password.");
                return;
            }
            
            Console.WriteLine("Login successful");
        }

        private string InputPassword()
        {
            var pass = new StringBuilder();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.Backspace:
                        if (pass.Length == 0) break;
                        pass.Length--;
                        Console.Write("\b \b");
                        break;
                    default:
                        pass.Append(key.KeyChar);
                        Console.Write("\u263A");
                        break;
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();

            return pass.ToString();
        }
    }
}