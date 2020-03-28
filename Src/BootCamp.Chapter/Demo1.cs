using System;

namespace BootCamp.Chapter
{
    internal static class Demo1
    {
        public static void Demo()
        {
            var Manager = new CredentialsManager("@File/user.txt");

            Enum choice = Intro();

            switch (choice)
            {
                case Menu.Choices.Register:

                    var inputtedData = Manager.PromptCredentials();
                    var splitted = inputtedData.Split(' ');
                    var credentials = new Credentials(splitted[0], splitted[1]);
                    Manager.Register(credentials);
                    break;

                case Menu.Choices.Login:

                    inputtedData = Manager.PromptCredentials();
                    splitted = inputtedData.Split(' ');
                    credentials = new Credentials(splitted[0], splitted[1]);
                    Manager.Login(credentials);
                    break;

                default:

                    Console.WriteLine("This is not a right choice. Only Register and Login are valid");
                    break;
            }
        }

        private static Menu.Choices Intro()
        {
            Console.WriteLine("Would you like to register or login");

            foreach (var menuchoice in Enum.GetValues(typeof(Menu.Choices)))
            {
                Console.WriteLine($"Choose {menuchoice} for {menuchoice}");
            }

            var choice = Console.ReadLine();
            var eNumChoice = (Menu.Choices) Enum.Parse(typeof(Menu.Choices), choice);
            return eNumChoice;
        }
    }
}