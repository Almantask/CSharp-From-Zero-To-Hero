using System;
using BootCamp.Chapter.ApplicationState;
using BootCamp.Chapter.UserInput;

namespace BootCamp.Chapter.Demo
{
    public class DemoApplication
    {
        public IApplicationStateController ApplicationStateController { get; }
        public IInputWatcher<ConsoleKey> InputWatcher { get; }

        public DemoApplication()
        {
            // We inject our dependencies through our ctor.
            ApplicationStateController = new ApplicationStateController();
            InputWatcher = new InputWatcher();
        }

        public void Run()
        {
            InitializeApplication();
            EndDemo();
            CloseApplication();
        }

        public void OnApplicationStateChange(object sender, ApplicationStateEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{sender.GetType().Name} - changing application state to {e.State}...");
            Console.ResetColor();
        }

        public void OnInputPressed(object sender, InputPressedEventArgs<ConsoleKey> e)
        {
            var key = e.Input;

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
            ApplicationStateController.ChangeState(ApplicationStates.APPLICATION_STARTED);
            InputWatcher.MonitorInput(GetUserInput());
        }

        private void EndDemo()
        {
            ApplicationStateController.ChangeState(ApplicationStates.DEMO_ENDED);
        }

        private void CloseApplication()
        {
            ApplicationStateController.ChangeState(ApplicationStates.APPLICATION_CLOSED);
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
