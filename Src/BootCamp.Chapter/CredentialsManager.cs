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
            var personData = InputData();
            string encodedPassWord = ConvertToUnicode(personData);
            for (int i = 0; i < 1; i++)
            {
                var person = fileData[i];
                var splitted = person.Split(";");
                if (splitted[1] == encodedPassWord & splitted[0] == personData.Name)
                {
                    isValidLogin = true;
                }
            }

            Console.WriteLine(isValidLogin);
        }

        private static string ConvertToUnicode(Person personData)
        {
            var password = Encoding.Unicode.GetBytes(personData.Password);
            var encodedPassWord = Encoding.Unicode.GetString(password);
            return encodedPassWord;
        }

        private static void Register()
        {
            var personData = InputData();
            string encodedPassWord = ConvertToUnicode(personData);
            var output = $"{personData.Name};{encodedPassWord}{Environment.NewLine}";
            File.AppendAllText(@"Database/user.txt", output);
        }

        private static Person InputData()
        {
            Console.WriteLine("May I have your name");
            var name = Console.ReadLine();
            Console.WriteLine("May I have your password");
            var input = Console.ReadLine();
            var person = new Person(name, input);
            return person;
        }
    }
}