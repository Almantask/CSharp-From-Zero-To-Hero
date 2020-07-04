using System;
using BootCamp.Chapter.ApplicationState;
using BootCamp.Chapter.UserInput;

namespace BootCamp.Chapter.Demo
{
    public class DemoApplication
    {
        public void Run()
        {
            InitializeApplication();
            EndDemo();
            CloseApplication();
        }

        public void OnApplicationStateChange(object sender, ApplicationStateEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{sender.GetType()} - changing application state to {e.State}...");
            Console.ResetColor();
        }

        public void OnInputPressed(object sender, InputPressedEventArgs e)
        {
            var key = sender as ConsoleKey?;

            switch (key)
            {
                case ConsoleKey.A:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsA);
                    break;
                case ConsoleKey.B:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsB);
                    break;
                case ConsoleKey.C:
                    ContactsCentreInitializer.Initialize(PeoplePredicates.IsC);
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

        private void InitializeApplication()
        {
            
        }

        private void EndDemo()
        {
            
        }

        private void CloseApplication()
        {
            
        }

        private ConsoleKey GetUserInput()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("a) Over 18, who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("b) Under 18,  who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("c) Who do not live in UK, whose surname and name does not contain letter 'a'.");

            return Console.ReadKey(true).Key;
        }
    }
}
