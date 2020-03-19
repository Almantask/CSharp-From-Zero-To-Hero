using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Login and Register features.\n");

            const string Register = "1";
            const string Login = "2";

            var credentialManager = new CredentialsManager();
            var option = "";
            var isLoginSuccessful = false;

            do
            {
                do
                {
                    option = Utilities.PromptText("Which option do you want ('1' for Register, '2' for Login)?");
                } while (option != Register && option != Login);

                if (option == Register)
                {
                    credentialManager.Register();
                }
                else //option == Login
                {
                    isLoginSuccessful = credentialManager.Login();
                }
            } while (!isLoginSuccessful);

            Console.WriteLine("The program has finished, because you have successfully logged in.");
        }
    }
}
