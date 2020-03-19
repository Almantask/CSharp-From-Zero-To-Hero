using System;
using System.IO;

namespace BootCamp.Chapter
{
    internal class CredentialsManager
    {
        internal static void Demo()
        {
            Console.WriteLine("Would you like to register or login");
            Console.WriteLine("Choose R for register");
            Console.WriteLine("Choose L for login");
            var choice = Console.ReadLine();
            switch (Enum.Parse(typeof(Menu), choice ) )
            {
                case Menu.MenuChoices.R:
                    Register();
                    break;

                case Menu.MenuChoices.L:
                    Login();
                    break;

                default:
                    Console.WriteLine("This is not a right choice. Only R and L are valid");
                    break;
            }
        }

        private static void Login()
        {
            var isValidLogin = false;
            var data = File.ReadAllText(@"Database/user.txt");
            var fileData = data.Split($"{Environment.NewLine}");
            var input = PromptCredentials();
            bool isValidInput = CredentialsParsing.TryParse(input, out CredentialsParsing.Credentials credentials);
            if (!isValidInput)
            {
                Console.WriteLine("You entered invalid data");
                return;
            }
            for (int i = 0; i < 1; i++)
            {
                var person = fileData[i];
                var splitted = person.Split(";");
                if (splitted[1] == credentials.Password & splitted[0] == credentials.Name)
                {
                    isValidLogin = true;
                }
            }

            Console.WriteLine(isValidLogin);
        }

        private static void Register()
        {
            var personData = PromptCredentials();
            bool isValidInput = CredentialsParsing.TryParse(personData, out CredentialsParsing.Credentials credentials);
            if (!isValidInput)
            {
                Console.WriteLine("You entered invalid data");
                return;
            }
            var output = $"{credentials.Name};{credentials.Password}{Environment.NewLine}";
            File.AppendAllText(@"Database/user.txt", output);
        }

        private static String PromptCredentials()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("May I have your name");
            var name = Console.ReadLine();
            Console.WriteLine("May I have your password");
            string input = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Enter)
                {
                    input += key.KeyChar;
                    Console.Write("\u263A");
                    Console.Write(" ");
                }
            } while (key.Key != ConsoleKey.Enter);

            return $"{name} {input}";
        }
    }
}