using BootCamp.Chapter.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class CredentialsManagerSimulator
    {
        private const string credentialsFile = @"..\..\..\Database\Userdata.db";

        public static void Run()
        {
            var mainMenu = new ConsoleNavigator();
            var selectedMenu = mainMenu.RenderMenu();

            if (selectedMenu == (int)MenuOptions.Login)
            {
                PerformLogin();
            }
            else if (selectedMenu == (int)MenuOptions.Register)
            {
                PerformRegistration();
            }
            else if (selectedMenu == (int)MenuOptions.Exit)
            {
                ExitSimulation();
            }
        }

        private static void PerformLogin()
        {
            Console.Write("Please enter your username: ");
            var username = Console.ReadLine();

            Console.Write("Please enter your password: ");
            var password = Console.ReadLine();

            Credentials credentials = new Credentials(username, password);
            CredentialsManager credentialsManager = new CredentialsManager(credentialsFile);
            if (credentialsManager.Login(credentials))
            {
                Console.WriteLine("You have been succesfully logged in.");
            }
            else
            {
                Console.WriteLine("Incorrect username or password.");
            }
        }

        private static void PerformRegistration()
        {
            Console.Write("Please enter your username: ");
            var username = Console.ReadLine();

            Console.Write("Please enter your password: ");
            var password = Console.ReadLine();

            Credentials credentials = new Credentials(username, password);
            CredentialsManager credentialsManager = new CredentialsManager(credentialsFile);
            credentialsManager.Register(credentials);

            Console.WriteLine("Your account has been successfully registered.");
        }

        private static void ExitSimulation()
        {
            Environment.Exit(0);
        }
    }
}
