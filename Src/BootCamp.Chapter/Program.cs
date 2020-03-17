using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var _credentialManager = new CredentialsManager();
            var option = "";

            do
            {
                Console.WriteLine("Which option do you want?  '1' for Register, '2' for Login");
                option = Console.ReadLine();
            } while (option != "1" && option != "2");

            if (option == "1")
            {
                _credentialManager.Register();
            }
            else //option == "2"
            {
                _credentialManager.Login();
            }

            Console.WriteLine("The program is done.");
        }
    }
}
