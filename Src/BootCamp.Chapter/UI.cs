using System;
using System.Text;

namespace BootCamp.Chapter
{
    class UI
    {
        readonly char passwordChar = '*';

        public Credentials GetUserProfile(string action, string message)
        {
            Console.Clear();
            Console.WriteLine(action);
            if (!string.IsNullOrEmpty(message))
            {
                Console.WriteLine(message);
            }
            Credentials returnCredential;
            try
            {
                returnCredential = PromptAccount();
            }
            catch (ArgumentException)
            {
                returnCredential = GetUserProfile(action, "Name cannot be empty!");
            }
            return returnCredential;
        }

        Credentials PromptAccount()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string unparsedPassword = HiddenReadLine(passwordChar);
            
            var utf8 = Encoding.UTF8;
            var bytes = utf8.GetBytes(unparsedPassword);
            string password = string.Join("", bytes);
            return new Credentials(username, password);
        }   

        string HiddenReadLine(char hidenChar)
        {
            string typedAsFar = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                // make sure the key is in the range
                if (((int)key.Key) >= 48 && ((int)key.Key <= 90))
                {
                    typedAsFar += key.KeyChar;
                    Console.Write(hidenChar);
                } //exit if key is enter and go to a new line

                // backspace logic
                if (key.Key == ConsoleKey.Backspace && typedAsFar.Length > 0)
                {
                    Console.Write("\b \b");
                    typedAsFar = typedAsFar.Substring(0, typedAsFar.Length - 1);
                }
            } while (key.Key != ConsoleKey.Enter);
            Console.WriteLine();

            return typedAsFar;
        }
    }
}
