using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    static class Demo1
    {
        public static void Demo()
        {
            var Manager = new CredentialsManager(""); 
            
            Console.WriteLine("Would you like to register or login");

            Console.WriteLine("Choose R for register");

            Console.WriteLine("Choose L for login");

            var choice = Console.ReadLine();

            switch (Enum.Parse(typeof(Menu), choice))

            {
                case Menu.MenuChoices.R:

                    var inputtedData = Manager.PromptCredentials(); 
                    var splitted = inputtedData.Split(' ');
                    var credentials = new Credentials(splitted[0], splitted[1]);
                    Manager.Register(credentials);

                    break;

                case Menu.MenuChoices.L:

                    inputtedData = Manager.PromptCredentials();
                    splitted = inputtedData.Split(' ');
                    credentials = new Credentials(splitted[0], splitted[1]);
                    Manager.Login(credentials);

                    break;

                default:

                    Console.WriteLine("This is not a right choice. Only R and L are valid");

                    break;
            }
        }
    }
}
