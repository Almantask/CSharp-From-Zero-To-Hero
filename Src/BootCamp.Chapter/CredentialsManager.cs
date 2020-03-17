using System;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
    internal class CredentialsManager
    {
        public struct Person
        {
            public Person(string name, string password)
            {
                Name = name;
                Password = password;
            }

            public string Name { get; set; }
            public string Password { get; set; }
        }

        internal static void Demo()
        {
            Console.WriteLine("Would you like to register or login");
            Console.WriteLine("Choose R voor register");
            Console.WriteLine("Choose L voor login");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "R":
                    Register();
                    break;

                case "L":
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
            var input = InputData();
            bool isValidInput = TryParse(input, out Person personData);
            for (int i = 0; i < 1; i++)
            {
                var person = fileData[i];
                var splitted = person.Split(";");
                if (splitted[1] == personData.Password & splitted[0] == personData.Name)
                {
                    isValidLogin = true;
                }
            }

            Console.WriteLine(isValidLogin);
        }

        private static bool TryParse(string input, out Person person)
        {
            person = new Person(); 
            if (String.IsNullOrEmpty(input))
            {
                return false; 
            }

            var parts = input.Split(" "); 

            if (parts.Length != 2)
            {
                return false; 
            }


            var name = parts[0]; 
            var password = Encoding.Unicode.GetBytes(parts[1]);
            var encodedPassWord = Encoding.Unicode.GetString(password);

            person = new Person(name, encodedPassWord);

            return true;  
        }

        private static void Register()
        {
            var personData = InputData();
            bool isValidInput = TryParse(personData, out Person person);
            var output = $"{person.Name};{person.Password}{Environment.NewLine}";
            File.AppendAllText(@"Database/user.txt", output);
        }

        private static String InputData()
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