using BootCamp.Chapter.Events;
using System;
using System.Transactions;

namespace BootCamp.Chapter.Demo
{
    public static class DemoDelegatesAndEvents
    {
        private static event EventHandler<ApplicationStateEventArgs> ApplicationStateHandler;
        private static event EventHandler<InputPressedEventArgs> InputHandler;

        public static void Run()
        {
            // Subscribe for events so we can catch input presses and application state changes
            ApplicationStateHandler += ApplicationStateEvents.OnApplicationStateChange;
            InputHandler += InputEvents.OnInputPressed;

            InitializeApplication();
            EndDemo();
            CloseApplication();
        }

        private static void InitializeApplication()
        {
            ApplicationStateHandler?.Invoke("Method: InitializeApplication", new ApplicationStateEventArgs(ApplicationState.APPLICATION_STARTED));
            InputHandler?.Invoke(GetUserInput(), new InputPressedEventArgs());

            
        }

        private static void EndDemo()
        {
            ApplicationStateHandler?.Invoke("Method: EndDemo", new ApplicationStateEventArgs(ApplicationState.DEMO_ENDED));
        }

        private static void CloseApplication()
        {
            ApplicationStateHandler?.Invoke("Method: CloseApplication", new ApplicationStateEventArgs(ApplicationState.APPLICATION_CLOSED));

            // Unsubscribe from events so objects can be destroy by the GC
            ApplicationStateHandler -= ApplicationStateEvents.OnApplicationStateChange;
            InputHandler -= InputEvents.OnInputPressed;
        }

        private static ConsoleKey GetUserInput()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("a) Over 18, who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("b) Under 18,  who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("c) Who do not live in UK, whose surname and name does not contain letter 'a'.");

            return Console.ReadKey(true).Key;
        }
    }
}
