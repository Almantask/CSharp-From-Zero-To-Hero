using System;

using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _fileName;

        public CredentialsManager(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException(); 
            }
            _fileName = fileName; 
        }
        

        public bool Login(Credentials credentials)
        {
            var isValidLogin = false;

            var data = File.ReadAllText(_fileName);

            if (String.IsNullOrEmpty(data))
            {
                return false; 
            }

            var fileData = data.Split($"{Environment.NewLine}");

            for (int i = 0; i < 1; i++)

            {
                var data2 = fileData[i];

                var splitted = data2.Split(",");

                var credentials2 = new Credentials(splitted[0], splitted[1]);

                isValidLogin = credentials.Equals(credentials2); 
               
            }

            return isValidLogin; 
        }

        public void Register(Credentials credentials)

        {
            var output = $"{credentials.Username}, {credentials.Password}{Environment.NewLine}"; 
            File.AppendAllText(_fileName, output);
        }

        public String PromptCredentials()

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

            return $"{name},{input}";
        }
    }
}